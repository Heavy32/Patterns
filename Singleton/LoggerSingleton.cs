using System;
using System.IO;


namespace Singleton
{
    public sealed class LoggerSingleton
    {
        public static readonly Lazy<LoggerSingleton> instance = new Lazy<LoggerSingleton>(() => new LoggerSingleton());

        private LoggerSingleton() { }

        public void WriteInLog(string logMessage)
        {
            DateTime now = DateTime.Now;

            string writePath = @"~\Singleton\Logger.txt";

            using StreamWriter logger = new StreamWriter(writePath, true, System.Text.Encoding.Default);
                logger.WriteLine("Log ID: " + LogID++ + " Date:" + now + " " + logMessage);

        }

        public int LogID { get; set; } = 1;
    }
}
