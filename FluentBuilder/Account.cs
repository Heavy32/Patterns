using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilder
{
    public class Account
    {
        protected string name;
        protected int age;
        protected string nickName;
        protected bool isMarried; //not instal and always false?

        public class AccountBuilder
        {
            private Account account;

            public AccountBuilder()
            {
                account = new Account();
            }

            public AccountBuilder SetName(string name)
            {
                account.name = name;
                return this;
            }

            public AccountBuilder SetAge(int age)
            {
                account.age = age;
                return this;
            }

            public AccountBuilder SetNickName(string nickName)
            {
                account.nickName = nickName;
                return this;
            }

            public AccountBuilder SetIsMarried(bool isMarried)
            {
                account.isMarried = isMarried;
                return this;
            }

            public Account Build()
            {
                return account;
            }
        }
    }
}
