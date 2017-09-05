using System.Collections.Generic;
using Assets.Scripts.Game.Plugin;

namespace Assets.Scripts.Game
{
    /// <summary>
    /// </summary>
    internal partial class Mafia
    {
        /// <summary>
        ///     伴随日志上报的静态参数
        /// </summary>
        public static readonly Dictionary<string, string> LogContext = new Dictionary<string, string>();

        public static void LogPutData(string key, string value)
        {
            LogContext.Add(key, value);
        }

        public static void LogClearData(string key, string value)
        {
            LogContext.Clear();
        }

        public static void Debug(string msg, object[] args = null, string throwable = "")
        {
            Debug(args == null ? msg : string.Format(msg, args), throwable);
        }

        public static void Debug(string msg, string throwable = "")
        {
            LogReport(new LogMessage
            {
                LogLevel = LogLevel.Debug,
                Context = LogContext,
                Message = msg,
                Throwable = throwable
            });
        }

        public static void Info(string msg, object[] args = null, string throwable = "")
        {
            Info(args == null ? msg : string.Format(msg, args), throwable);
        }

        public static void Info(string msg, string throwable = "")
        {
            LogReport(new LogMessage
            {
                LogLevel = LogLevel.Info,
                Context = LogContext,
                Message = msg,
                Throwable = throwable
            });
        }

        public static void Warn(string msg, object[] args = null, string throwable = "")
        {
            Warn(args == null ? msg : string.Format(msg, args), throwable);
        }

        public static void Warn(string msg, string throwable = "")
        {
            LogReport(new LogMessage
            {
                LogLevel = LogLevel.Warn,
                Context = LogContext,
                Message = msg,
                Throwable = throwable
            });
        }

        public static void Error(string msg, object[] args = null, string throwable = "")
        {
            Error(args == null ? msg : string.Format(msg, args), throwable);
        }

        public static void Error(string msg, string throwable)
        {
            LogReport(new LogMessage
            {
                LogLevel = LogLevel.Error,
                Context = LogContext,
                Message = msg,
                Throwable = throwable
            });
        }

        private static void LogReport(LogMessage message)
        {
            var plugin = Instance.GetPlugin<LogPlugin>();
            if (plugin != null && plugin.Enable)
                plugin.Write(message);
        }
    }
}