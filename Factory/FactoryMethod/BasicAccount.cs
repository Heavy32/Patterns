using System;

namespace Factory
{
    class BasicAccount : Account
    {
        public BasicAccount(string name, int age) : base(name, age)
        {
            maxFriendsCount = 50;
        }

        public override void WelcomeMessage()
        {
            Console.WriteLine($"Hello, {Name}! Congrats! You've created a basic account. Get your {maxFriendsCount} friends know you're here!");
        }
    }
}
