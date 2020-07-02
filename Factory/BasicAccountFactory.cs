namespace Factory
{
    class BasicAccountFactory : IAccountBuilder
    {
        public override Account Create(string name, int age)
        {
            return new BasicAccount(name, age);
        }
    }
}
