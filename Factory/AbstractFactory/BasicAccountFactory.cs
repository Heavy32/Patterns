namespace Factory
{
    class BasicAccountBuilder : IAccountBuilder
    {
        private readonly string name;
        private readonly int age;

        public BasicAccountBuilder(string name, int age)
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
