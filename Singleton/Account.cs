using System;
using System.Threading;

namespace Singleton
{
    class Account
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Account(string name, int age)
        {
            Name = name;
            Age = age;
            AccountCounter.Instance.count++;
        }
    }
}
