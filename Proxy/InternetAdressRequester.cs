using System;

namespace Decorator
{
    class InternetAdressRequester : IRequester
    {
        private string adress;

        public string Adress { get => adress; set => adress = value; }

        public InternetAdressRequester(string adress)
        {
            Adress = adress;
        }

        public void Request()
        {
            Console.WriteLine("Sending request to: " + adress);
        }
    }
}
