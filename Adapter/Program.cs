using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class SuperSecretClass
    { 
        public void SecretAction()
        {
            Console.WriteLine("secret");
        }
    }

    interface IShow
    {
        public void Show();
    }

    class AdapterSuperSecretClass : SuperSecretClass, IShow
    {
        public void Show()
        {
            base.SecretAction();
        }
    }
}
