namespace Decorator
{
    public class AntiSpam : TextFilter
    {
        public AntiSpam(TextFilter textFilter = null) : base(textFilter) { }

        public override string Filter(string text)
        {
            text = base.Filter(text);

            if (text.Contains("https://"))
                text = "Message has been removed because of spam";

            return text;
        }
    }
}
