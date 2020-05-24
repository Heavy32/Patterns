using System;

namespace Decorator
{
    class EmojiMessageDecorator : MessageDecorator
    {
        public EmojiMessageDecorator(Message message) : base(message)
        {
            base.message = EmojiFilter(message); 
        }

        public override string GetMessage()
        {
            return EmojiFilter(message).Text;
        }

        private Message EmojiFilter(Message message)
        {
            string text = message.Text;

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (text.Contains(":-)"))
                text = text.Replace(":-)", "\x263A");

            if (text.Contains(":-("))
                text = text.Replace(":-(", "\x2639");

            if (text.Contains("<3"))
                text = text.Replace("<3", "\x2764");

            message.Text = text;
            return message;
        }
    }
}
