using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class AccountFactory : IAccountFactory
    {
        public Account Create(string name, int age, string? profilePicture, AccountType type)
        {
            return type switch
            {
                AccountType.Basic => new BasicAccount(name, age),
                AccountType.VIP => new VipAccount(name, age, profilePicture),
                _ => throw new Exception("Cannot create account"),
            };
        }
    }
}
