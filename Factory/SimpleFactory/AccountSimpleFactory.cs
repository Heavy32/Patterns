using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SimpleFactory
{
    class AccountSimpleFactory
    {
        public Account CreateBasicAccount(string name, int age)
        {
            return new BasicAccount(name, age);
        }

        public Account CreateVipAccount(string name, int age, string profilePicture)
        {
            return new VipAccount(name, age, profilePicture);
        }
    }
}
