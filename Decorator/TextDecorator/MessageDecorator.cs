namespace Decorator
{
    public class MessageDecorator : IMessage
    {
        protected IMessage message;

        public MessageDecorator(IMessage message)
        {
            this.message = message;
        }

        public string GetMessage()
        {
            return message.GetMessage();
        }

        public void SetMessage(string text)
        {
            message.SetMessage(text);
        }
    }
}
