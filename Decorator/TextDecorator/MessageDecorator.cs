namespace Decorator
{
    abstract class MessageDecorator : Message
    {
        protected Message message;

        public MessageDecorator(Message message) : base(message.Text)
        {
            this.message = message;
        }
    }
}
