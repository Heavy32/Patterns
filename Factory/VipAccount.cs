using System;

namespace Factory
{
    class VipAccount : Account
    {
        private string profilePicture;

        public VipAccount(string name, int age, string profilePicture) : base("VIP" + name, age)
        {
            maxFriendsCount = 500;
            this.profilePicture = profilePicture;
        }

        public override void WelcomeMessage()
        {
            Console.WriteLine($"What'up, {Name}? You've created a VIP account. Look at this dude: {profilePicture}, he is awesome! Your {maxFriendsCount} are ready to know who the boss is");
        }
    }
}
