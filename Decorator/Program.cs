using System;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "FUCK YOU https://forums.envato.com/t/check-if-string-is-a-url/75760/2";
            Console.WriteLine(new ReplaceBadWords(new RemoveCapsLockRage(new AntiSpam())).Filter(text));
        }
    }   
}
