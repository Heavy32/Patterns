using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            (new Thread(() =>
            {
                LoggerSingleton.instance.Value.WriteInLog("Sup");
            })).Start();

            LoggerSingleton.instance.Value.WriteInLog("Nigga");
            Console.Read();
            LoggerSingleton.instance.Value.FinishLogger();
        }
    }
}
