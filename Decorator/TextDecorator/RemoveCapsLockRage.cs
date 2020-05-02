namespace Decorator
{
    public class RemoveCapsLockRage : TextFilter
    {
        public RemoveCapsLockRage(TextFilter textFilter = null) : base(textFilter) { }

        public override string Filter(string text)
        {
            return base.Filter(text).ToLower();
        }
    }
}
