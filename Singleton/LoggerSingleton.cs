using System;
using System.IO;


namespace Singleton
{
    public sealed class LoggerSingleton : IDisposable
    {
        private static readonly Lazy<LoggerSingleton> instance = new Lazy<LoggerSingleton>(() => new LoggerSingleton());
        private bool disposed = false;

        private LoggerSingleton()
        {
            Logger = new StreamWriter("Logger.txt");
        }

        public void WriteInLog(string logMessage)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(logMessage, LogID);
            Logger.Write("Log ID: " + LogID++ + " Date:"  + now + " " + logMessage + "\n");
        }

        public void FinishLogger()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(Logger);
        }

        private void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                Logger.Dispose();
            }

            disposed = true;
        }

        public static LoggerSingleton Instance { get => instance.Value; }
        public int LogID { get; set; } = 1;
        public StreamWriter Logger { get; set; }
    }
}
