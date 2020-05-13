using System;
using System.IO;

namespace Singleton
{
    public sealed class LoggerSingleton
    {
        public static readonly Lazy<LoggerSingleton> instance = new Lazy<LoggerSingleton>(() => new LoggerSingleton());
        private static readonly object syncRoot = new object();

        private LoggerSingleton() { }

        public void WriteInLog(string logMessage)
        {
            DateTime now = DateTime.Now;

            string writePath = @"C:\Users\eBasher\Documents\GitHub\Patterns\Singleton\Logger.txt";

            lock (syncRoot)
            {
                using StreamWriter logger = new StreamWriter(writePath, true, System.Text.Encoding.Default);
                    logger.WriteLine("Log ID: " + LogID++ + " Date:" + now + " " + logMessage);
            }           
        }

        public int LogID { get; set; } = 1;
    }
}
