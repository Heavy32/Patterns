namespace Decorator
{
    public class SimpleMessage : IMessage
    {
        private string text;

        public string GetMessage()
        {
            return text;
        }

        public void SetMessage(string text)
        {
            this.text = text;
        }
    }
}
