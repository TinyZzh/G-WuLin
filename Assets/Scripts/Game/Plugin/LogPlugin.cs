using System.Collections.Generic;
using Assets.Scripts.Game.Utils;
using Google.Protobuf;
using Org.OkraAx.V3;

namespace Assets.Scripts.Game.Plugin
{
    /// <summary>
    ///     日志插件. 用于本地错误日志输出, 日志上报等等. 插件默认不启用, 有服务端控制是否启用
    /// </summary>
    internal class LogPlugin : ComplexNetPlugin
    {
        /// <summary>
        ///     Log Message Queue.
        /// </summary>
        private readonly Queue<LogMessage> _msgQueue = new Queue<LogMessage>();

        /// <summary>
        ///     最后一次上报的时间.
        /// </summary>
        private volatile float _lastReportTime = 0.0f;

        /// <summary>
        ///     当前日志队列长度
        /// </summary>
        private volatile int _length = 1;

        /// <summary>
        ///     最后一次上报的时间, 超过间隔时间时,触发Flush上报日志. 单位:毫秒
        /// </summary>
        public int QueueFlushInterval = 60000;

        /// <summary>
        ///     日志队列长度. 超过一定长度, 触发Flash上报日志
        /// </summary>
        public int QueueFlushLength = 1;

        public LogPlugin()
        {
            Enable = false;
        }

        public override void InitPlugin()
        {
            RegisterMethod("CallbackGetLogReportUrl", typeof(LogServerInfoBean), CallbackGetLogReportUrl);
            PushEvent("onGetLogReportUrl", new GpcVoid());
        }

        public void CallbackGetLogReportUrl(IMessage msg)
        {
            Enable = true;

            //  TODO: 连接日志服务器 - 目前直接上报给login进程

        }

        public void WriteAndFlush(LogMessage message)
        {
            Write(message);
            Flush();
        }

        public void Write(LogMessage message)
        {
            _msgQueue.Enqueue(message);
            TryFlush();
        }

        /// <summary>
        ///     满足条件时触发Flush()
        /// </summary>
        private void TryFlush()
        {
            if (_length < QueueFlushLength && GameClock.Timestamp - _lastReportTime < 60000)
                return;
            Flush();
        }

        /// <summary>
        ///     上报日志
        /// </summary>
        public void Flush()
        {
            var data = new ReportClientLogBean();
            LogMessage logMessage;
            while ((logMessage = _msgQueue.Dequeue()) != null)
                data.List.Add(new ClientLogMessage
                {
                    Context =
                    {
                        logMessage.Context
                    },
                    LogLevel = (int) logMessage.LogLevel,
                    Message = logMessage.Message,
                    Throwable = logMessage.Throwable
                });
            if (data.List.Count > 0)
                PushEvent("onReportClientLog", data);
        }

        public void Report(LogMessage message)
        {
            if (!Enable)
                return;
            Write(message);
        }
    }

    internal enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error
    }

    /// <summary>
    ///     上报日志信息
    /// </summary>
    internal class LogMessage
    {
        /// <summary>
        ///     数据
        /// </summary>
        public Dictionary<string, string> Context = new Dictionary<string, string>();

        /// <summary>
        ///     日志等级
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        ///     附加信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     异常信息
        /// </summary>
        public string Throwable { get; set; }
    }
}