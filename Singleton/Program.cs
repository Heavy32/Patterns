using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Task.Run(() =>
            {
                LoggerSingleton.instance.Value.WriteInLog("Hello");
            });

            LoggerSingleton.instance.Value.WriteInLog("Leha");
        }
    }
}
