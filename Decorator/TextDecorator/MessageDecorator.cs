namespace Decorator
{
    public abstract class MessageDecorator : IMessage
    {
        private readonly IMessage message;

        public MessageDecorator(IMessage message)
        {
            this.message = message;
        }

        public virtual string GetMessage()
        {
            return message.GetMessage();
        }

        public virtual void SetMessage(string text)
        {
            message.SetMessage(text);
        }
    }
}
