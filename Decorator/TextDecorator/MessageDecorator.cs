namespace Decorator
{
    public class MessageDecorator : IMessage
    {
        protected IMessage message;

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
