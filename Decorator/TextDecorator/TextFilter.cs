using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
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
}
