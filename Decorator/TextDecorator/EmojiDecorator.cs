using System;

namespace Decorator
{
    public class EmojiDecorator : TextFilter
    {
        public EmojiDecorator(TextFilter textFilter = null) : base(textFilter) { }

        public override string Filter(string text)
        {
            text = base.Filter(text);
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
