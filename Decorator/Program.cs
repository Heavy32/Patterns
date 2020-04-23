using System;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFilter textFilter = new EmojiDecorator();
            Console.WriteLine(textFilter.Filter("BAZINGA :-)"));
            Console.WriteLine(textFilter.Filter("PATHETIC :-("));
            Console.WriteLine(textFilter.Filter("I <3 C# "));
        }
    }   
}
