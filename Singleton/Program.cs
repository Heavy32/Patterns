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
            Task t1 = new Task(() => LoggerSingleton.instance.Value.WriteInLog("Hello"));
            Task t2 = new Task(() => LoggerSingleton.instance.Value.WriteInLog("Leha"));

            t1.Start();
            t1.Wait();

            t2.Start();
            t2.Wait();
        }
    }
}
