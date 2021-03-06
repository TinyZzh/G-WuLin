﻿using System;
using Assets.Scripts.Game.Core;
using Google.Protobuf;
using Org.OkraAx.V3;

namespace Assets.Scripts.Game.Plugin
{
    internal abstract class ComplexNetPlugin : AbstractPlugin
    {
        public void RegisterMethod(string method, Type paramType, Action<IMessage> action)
        {
            var netPlugin = Mafia.Instance.GetPlugin<NetPlugin>();
            if (netPlugin != null)
                netPlugin.RegisterMethod(method, paramType, action);
        }

        /// <summary>
        ///     发送消息到服务端. 异步回调callback.服务器有可能无响应.
        /// </summary>
        /// <param name="api">远程服务接口</param>
        /// <param name="param">接口参数</param>
        /// <param name="callback">异步回调函数</param>
        public void OnEvent<TM>(string api, IMessage param, Action<TM> callback)
            where TM : class, IMessage
        {
            var netPlugin = Mafia.Instance.GetPlugin<NetPlugin>();
            if (netPlugin != null)
                netPlugin.OnEvent(new GpcCall
                {
                    Method = api,
                    Params = param.ToByteString()
                }, callback);
        }

        /// <summary>
        ///     发送消息到服务端. 无回调
        /// </summary>
        /// <param name="api">远程服务接口</param>
        /// <param name="param">接口参数</param>
        public void PushEvent(string api, IMessage param)
        {
            var netPlugin = Mafia.Instance.GetPlugin<NetPlugin>();
            if (netPlugin != null)
                netPlugin.PushEvent(new GpcCall
                {
                    Method = api,
                    Params = param.ToByteString()
                });
        }
    }
}