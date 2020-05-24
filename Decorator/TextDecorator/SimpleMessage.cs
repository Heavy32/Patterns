namespace Decorator
{
    class SimpleMessage : Message
    {
        public SimpleMessage(string text) : base(text)
        { }

        public override string GetMessage()
        {
            return Text;
        }
    }
}
