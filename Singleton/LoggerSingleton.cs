using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.IO;

namespace Singleton
{
    public sealed class LoggerSingleton : IDisposable
    {
        private static readonly Lazy<LoggerSingleton> instance = new Lazy<LoggerSingleton>(() => new LoggerSingleton());
        private int logID = 1;
        private StreamWriter logger;
        private bool disposed = false;
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private LoggerSingleton() { }

        public void StartLogger()
        {
            Logger = new StreamWriter("Logger1.txt");
        }

        public void WriteInLog(string logMessage)
        {
            DateTime now = DateTime.Now;
            Logger.Write("Log ID: " + LogID + " Date:"  + now + " " + logMessage + "\n");
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
        public int LogID { get => logID; set => logID = value; }
        public StreamWriter Logger { get => logger; set => logger = value; }
    }
}
