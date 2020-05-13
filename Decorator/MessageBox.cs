using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class MessageBox
    {
        private string text;
        public string Text { get => text; set => text = new EmojiDecorator().Filter(value); }
    }
}
