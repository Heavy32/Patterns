using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessage m = new SimpleMessage();
            m.SetMessage("I love you <3");

            m = new EmojiDecorator(m);
            Console.WriteLine(m.GetMessage());
        }
    }   
}
