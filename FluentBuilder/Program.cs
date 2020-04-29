using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilder
{
    class Program
    {
        static void Main()
        {
            Account account = new Account.AccountBuilder().SetName("Max").SetNickName("Nagibator228").SetIsMarried(false).SetAge(23).Build();
        }
    }
}
