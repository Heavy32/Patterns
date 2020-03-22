using System;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "FUCK YOU https://forums.envato.com/t/check-if-string-is-a-url/75760/2";
            Console.WriteLine(new ReplaceBadWords(new RemoveCapsLockRage(new AntiSpam())).Filter(text));
        }
    }

    public abstract class TextFilter
    {
        private TextFilter textFilter;

        protected TextFilter(TextFilter textFilter = null)
        {
            this.textFilter = textFilter;
        }

        public virtual string Filter(string text)
        {
            if (textFilter != null)
                text = textFilter.Filter(text);

            return text;
        }
    }

    public class ReplaceBadWords : TextFilter
    {
        public ReplaceBadWords(TextFilter textFilter = null) : base(textFilter) { }

        public override string Filter(string text)
        {
            text = base.Filter(text);

            if (text.Contains("fuck"))
                text = text.Replace("fuck", "love");

            if (text.Contains("moron"))
                text = text.Replace("moron", "honey");

            if (text.Contains("fucking"))
                text = text.Replace("fucking", "beloved");

            if (text.Contains("douchebag"))
                text = text.Replace("douchebag", "the best person alive");

            return text;
        }
    }

    public class RemoveCapsLockRage : TextFilter
    {
        public RemoveCapsLockRage(TextFilter textFilter = null) : base(textFilter) { }

        public override string Filter(string text)
        {
            return base.Filter(text).ToLower();
        }
    }

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
