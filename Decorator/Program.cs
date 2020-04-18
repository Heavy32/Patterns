using System;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hey yo";
            Console.WriteLine(new ToUpperText(new ReplaceSpacesWithLog()).GetFormattedText(text));

        }
<<<<<<< HEAD
<<<<<<< HEAD
    }   
=======
    }

    public abstract class TextFormator
    {
        private TextFormator _textFormator;

        protected TextFormator(TextFormator textFormator = null)
        {
            _textFormator = textFormator;
        }

        public virtual string GetFormattedText(string text)
        {
            if (_textFormator != null)
            {
                text = _textFormator.GetFormattedText(text);
            }
=======
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
>>>>>>> parent of fbf344b... extract decorator

            return text;
        }
    }

<<<<<<< HEAD
    class ReplaceSpacesWithLog : TextFormator
    {
        public ReplaceSpacesWithLog(TextFormator textFormator = null) : base(textFormator) { }

        public override string GetFormattedText(string text)
        {
            Console.WriteLine($"All ' ' will replace to '+'");
            return base.GetFormattedText(text)?.Replace(' ', '+');
        }
    }

    public class ToUpperText : TextFormator
    {
        public ToUpperText(TextFormator textFormator = null) : base(textFormator) { }

        public override string GetFormattedText(string text)
        {
            return base.GetFormattedText(text).ToUpper();
        }
    }
>>>>>>> parent of c5e111b... Add Chat filter Decorator
=======
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
>>>>>>> parent of fbf344b... extract decorator
}
