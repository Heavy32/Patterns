namespace Factory
{
    class VipAccountBuilder : IAccountBuilder
    {
        public override Account Create(string name, int age, string profilePicture)
        {
            return new VipAccount(name, age, profilePicture);
        }
    }
}
