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

            return text;
        }
    }

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
}
