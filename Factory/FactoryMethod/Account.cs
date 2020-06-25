namespace Factory
{
    public abstract class Account
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected int maxFriendsCount;

        public Account(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void WelcomeMessage();
    }
}
