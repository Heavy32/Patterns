namespace Factory.FactoryMethod
{
    public interface IAccountFactory
    {
        public Account Create(string name, int age, string? profilePicture, AccountType type);
    }
}
