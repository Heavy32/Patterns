using System;

namespace Decorator
{
    public class EmojiDecorator : MessageDecorator
    {
        public EmojiDecorator(IMessage message) : base(message)
        { }

        public override string GetMessage()
        {
            string text = message.GetMessage();

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (text.Contains(":-)"))
                text = text.Replace(":-)", "\x263A");

            if (text.Contains(":-("))
                text = text.Replace(":-(", "\x2639");

            if (text.Contains("<3"))
                text = text.Replace("<3", "\x2764");

            return text;
        }
    }
}
