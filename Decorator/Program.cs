using System;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFilter textFilter = new EmojiDecorator(new RemoveCapsLockRage());
            string text = textFilter.Filter("BAZINGA :-*");
        }
    }   
}
