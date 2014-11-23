using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using log4net;

namespace ProjectAsylum.Core.Logging
{
    public class Logger
    {
        internal static ILog LoggerFor<T>()
        {
            return LogManager.GetLogger(typeof(T));
        }

        internal static ILog LoggerFor(object getTypeFromInstance)
        {
            if (getTypeFromInstance == null)
                throw new ArgumentNullException("getTypeFromInstance");

            return LogManager.GetLogger(getTypeFromInstance.GetType());
        }

        private static string PrefixId(string generateMessageFormat)
        {
            return "[Process " + Process.GetCurrentProcess().Id + "][Thread " + Thread.CurrentThread.ManagedThreadId + "] " + generateMessageFormat;
        }

        #region Debug

        public static void Debug<T>(Func<string> generateMessage)
        {
            Debug(typeof (T), generateMessage.Invoke(), null);
        }

        public static void Debug<T>(Func<string> generateMessage, params Func<object>[] formatItems)
        {
            Debug(typeof(T), generateMessage.Invoke(), formatItems);
        }

        public static void Debug(Type type, string generateMessageFormat, params Func<object>[] formatItems)
        {
            var logger = LogManager.GetLogger(type);

            if (logger == null || !logger.IsDebugEnabled)
                return;

            logger.DebugFormat(PrefixId(generateMessageFormat), formatItems.Select(x => x.Invoke()).ToArray());
        }

        #endregion
    }
}