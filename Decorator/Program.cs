using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new SimpleMessage("I love you <3");
            message = new EmojiMessageDecorator(message);
            Console.WriteLine(message.GetMessage());
        }
    }   
}
