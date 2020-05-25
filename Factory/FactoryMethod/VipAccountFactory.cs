namespace Factory
{
    class VipAccountFactory : IAccountFactory
    {
        private readonly string name;
        private readonly int age;
        private readonly string profilePicture;

        public VipAccountFactory(string name, int age, string profilePicture)
        {
            this.name = name;
            this.age = age;
            this.profilePicture = profilePicture;
        }

        public Account Create()
        {
            return new VipAccount(name, age, profilePicture);
        }
    }
}
