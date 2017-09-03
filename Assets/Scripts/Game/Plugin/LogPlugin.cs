using System.Collections.Generic;
using Assets.Scripts.Game.Utils;
using Google.Protobuf;

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
            //  TODO: 初始化日志服务器信息
//            RegisterMethod<Any>("CallbackGetLogReportUrl", CallbackGetLogReportUrl);
//            PushEvent("getLogReportUrl", new GpcVoid());
        }

        public void CallbackGetLogReportUrl(IMessage msg)
        {
            Enable = true;
        }

        public void WriteAndFlush(LogMessage message)
        {
            Write(message);
            Flush();
        }

        public void Write(LogMessage message)
        {
            _msgQueue.Enqueue(message);
        }


        public void Flush()
        {
            if (_length < QueueFlushLength && GameClock.Timestamp - _lastReportTime < 60000)
                return;
            //  TODO:推送到日志服务器
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
        public Dictionary<string, object> Context = new Dictionary<string, object>();

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