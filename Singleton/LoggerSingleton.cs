using System;
using System.IO;

namespace Singleton
{
    public sealed class LoggerSingleton
    {
        public static readonly Lazy<LoggerSingleton> instance = new Lazy<LoggerSingleton>(() => new LoggerSingleton());
        private readonly object syncRoot = new object();
        private LoggerSingleton() { }

        public void WriteInLog(string logMessage)
        {
            lock (syncRoot)
            {
                using StreamWriter logger = new StreamWriter(@"Logger.txt", true, System.Text.Encoding.Default);
                    logger.WriteLine("Log ID: " + LogID++ + " Date:" + DateTime.Now + " " + logMessage);
            }           
        }

        public long LogID { get; set; } = 1;
    }
}
