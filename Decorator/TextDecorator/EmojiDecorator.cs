namespace Decorator
{
    public class EmojiDecorator : TextFilter
    {
        public EmojiDecorator(TextFilter textFilter = null) : base(textFilter) { }

        public override string Filter(string text)
        {
            text = base.Filter(text);

            if (text.Contains(":-)"))
                text = text.Replace(":-)", "U+1F60A");

            if (text.Contains(":-D"))
                text = text.Replace(":-D", "U+1F601");

            if (text.Contains(":-*"))
                text = text.Replace(":-*", "U+1F618");

            return text;
        }
    }
}
