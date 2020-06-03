using System;

namespace Decorator
{
    public class EmojiDecorator : IMessageDecorator
    {
        private IMessage message;
        public EmojiDecorator(IMessage message)
        {
            this.message = message;
        }
        public void Decorate()
        {
            string text = message.GetMessage();

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (text.Contains(":-)"))
                text = text.Replace(":-)", "\x263A");

            if (text.Contains(":-("))
                text = text.Replace(":-(", "\x2639");

            if (text.Contains("<3"))
                text = text.Replace("<3", "\x2764");

            message.SetMessage(text);
        }

        public string GetMessage()
        {
            Decorate();
            return message.GetMessage();
        }

        public void SetMessage(string text)
        {
            message.SetMessage(text);
        }
    }
}
