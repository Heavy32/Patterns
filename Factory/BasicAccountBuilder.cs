namespace Factory
{
    class BasicAccountBuilder : IAccountBuilder
    {
        public override Account Create(string name, int age)
        {
            return new BasicAccount(name, age);
        }
    }
}
