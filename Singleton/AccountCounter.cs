using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class LoggerSingleton
    {
        private static readonly Lazy<LoggerSingleton> instance = new Lazy<LoggerSingleton>(() => new LoggerSingleton());
        private int logID = 1;
        private StreamWriter logger;

        private LoggerSingleton()
        {
            logger = new StreamWriter("logger.txt");
        }

        public void WriteInLog(string logMessage)
        {
            DateTime now = DateTime.Now;
            logger.Write("Log ID: " + logID + " Date:"  + now + " " + logMessage);
        }

        public void FinishLogger()
        {
            logger.Close();
        }

        public static LoggerSingleton Instance { get { return instance.Value; } }
    }
}
