using System;

namespace Adapter
{   //NOT FINISHED YET
    class Program
    {
        static void Main(string[] args)
        {
            AdapterSuperSecretClass a = new AdapterSuperSecretClass();
            a.Action();
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
            SecretAction();
        }
    }
}
