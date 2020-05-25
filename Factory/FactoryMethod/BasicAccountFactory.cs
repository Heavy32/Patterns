namespace Factory
{
    class BasicAccountFactory : IAccountFactory
    {
        private readonly string name;
        private readonly int age;

        public BasicAccountFactory(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Account Create()
        {
            return new BasicAccount(name, age);
        }
    }
}
