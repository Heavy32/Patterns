namespace Decorator
{
    abstract class Message
    {
        public string Text { get; set; }

        public Message(string text)
        {
            Text = text;
        }

        public abstract string GetMessage();
    }
}
