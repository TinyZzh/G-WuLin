using System;
using System.Collections.Generic;
using Assets.Scripts.Game.Core;
using Assets.Scripts.Game.Net;
using Assets.Scripts.Game.Utils;
using Google.Protobuf;
using Org.OkraAx.V3;

namespace Assets.Scripts.Game.Plugin
{
    /// <summary>
    ///     网络组件. 处理和服务端直接的通信.
    /// </summary>
    internal class NetPlugin : AbstractPlugin
    {
        /// <summary>
        /// </summary>
        private readonly SimpleSocket _mSocket = new SimpleSocket(4, 4);

        /// <summary>
        ///     临时回调
        /// </summary>
        protected readonly Dictionary<int, NetCallback> CallbacksDic = new Dictionary<int, NetCallback>();

        /// <summary>
        /// /* method name */ - 
        /// </summary>
        protected readonly Dictionary<string, NetCallback> MethodsDic = new Dictionary<string, NetCallback>();

        /// <summary>
        /// </summary>
        private volatile int _mId = 1;


        public override void Initialize()
        {
            _mSocket.Connect("127.0.0.1", 9007);
            _mSocket.ConnectCompleted += _mSocket_ConnectCompleted;
            _mSocket.ReceiveMessageCompleted += Socket_ReceiveMessageCompleted;
        }

        private void _mSocket_DisconnectCompleted(object sender, SocketEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _mSocket_ConnectCompleted(object sender, SocketEventArgs e)
        {
            PushEvent(new GpcCall()
            {
                Method = "onSyncTime",
                Params = new GpcVoid().ToByteString()
            });
        }

        private void Socket_ReceiveMessageCompleted(object sender, SocketEventArgs e)
        {
            var call = GpcCall.Parser.ParseFrom(e.Data);
            if (!MethodsDic.ContainsKey(call.Method))
                return;
            var cb = MethodsDic[call.Method];
            if (cb.Param == null)
                return;
            var mMsg = Activator.CreateInstance(cb.Param, null);
            if (!(mMsg is IMessage))
                return;
            (mMsg as IMessage).MergeFrom(call.Params);
            if (cb.InvokedMethod != null)
                cb.InvokedMethod(mMsg as IMessage);
        }

        /// <summary>
        /// 注册回调接口
        /// </summary>
        /// <typeparam name="TM">回调函数的参数类型</typeparam>
        /// <param name="method">访问远程服务名</param>
        /// <param name="action">回调函数</param>
        public void RegisterMethod<TM>(string method, Action<TM> action)
            where TM : class, IMessage
        {
            MethodsDic.Add(method, new NetCallback
            {
                Param = typeof(TM),
                InvokedMethod = action as Action<IMessage>
            });
        }

        /// <summary>
        ///     发送消息到服务端. 注册回调函数, 等待服务端返回后回收.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="callback">回调函数</param>
        public void OnEvent<TM>(IMessage msg, Action<TM> callback)
            where TM : class, IMessage
        {
            if (msg == null) return;
            if (callback != null)
            {
                var id = _mId++;
                CallbacksDic.Add(id, new NetCallback
                {
                    ID = id,
                    InvokedMethod = callback as Action<IMessage>,
                    Dateline = GameClock.Timestamp,
                    Param = typeof(TM)
                });
            }
            _mSocket.OnSendMessage(msg);
        }

        /// <summary>
        ///     发送消息到服务端. 无回调
        /// </summary>
        /// <param name="msg"></param>
        public void PushEvent(IMessage msg)
        {
            _mSocket.OnSendMessage(msg);
        }
    }
}