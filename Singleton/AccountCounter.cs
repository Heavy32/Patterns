using System;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> parent of 4f4f6a8... Add disposable, add properties, repair
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
<<<<<<< HEAD
    public sealed class AccountCounter
    {
        private static readonly Lazy<AccountCounter> lazy = new Lazy<AccountCounter>(() => new AccountCounter());

        public static AccountCounter Instance { get { return lazy.Value; } }
        public int count = 0;

        private AccountCounter() { }
=======
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
>>>>>>> parent of 4f4f6a8... Add disposable, add properties, repair
    }
}
