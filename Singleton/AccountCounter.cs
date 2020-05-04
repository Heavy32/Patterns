using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class AccountCounter
    {
        private static readonly Lazy<AccountCounter> lazy = new Lazy<AccountCounter>(() => new AccountCounter());        
        public static AccountCounter Instance { get { return lazy.Value; } }
        public int count = 0;

        private AccountCounter() { }
    }
}
