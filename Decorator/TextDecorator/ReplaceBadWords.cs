namespace Decorator
{
    public class ReplaceBadWords : TextFilter
    {
        public ReplaceBadWords(TextFilter textFilter = null) : base(textFilter) { }

        public override string Filter(string text)
        {
            text = base.Filter(text);

            if (text.Contains("moron"))
                text = text.Replace("moron", "honey");

            if (text.Contains("fucking"))
                text = text.Replace("fucking", "beloved");

            if (text.Contains("douchebag"))
                text = text.Replace("douchebag", "the best person alive");

            return text;
        }
    }
}
