using System.Threading.Tasks;

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
