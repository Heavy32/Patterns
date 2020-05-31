namespace Decorator
{
    public abstract class MessageDecorator : IMessage
    {
        protected IMessage message;

        public MessageDecorator(IMessage message)
        {
            this.message = message;
        }

        public abstract string GetMessage();

        public void SetMessage(string text)
        {
            message.SetMessage(text);
        }
    }
}
