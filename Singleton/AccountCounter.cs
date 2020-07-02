using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton
{
    public sealed class LoggerSingleton
    {
        private static readonly Lazy<LoggerSingleton> instance = new Lazy<LoggerSingleton>(() => new LoggerSingleton());
        private int logNumber = 0;
        private StreamWriter logger;

        private LoggerSingleton()
        {
            logger = new StreamWriter("logger.txt");
        }

        public void WriteInLog(string logMessage)
        {
            logger.Write(logMessage);
        }

        public void FinishLogger()
        {
            logger.Close();
        }

        public static LoggerSingleton Instance { get { return instance.Value; } }
    }
}
