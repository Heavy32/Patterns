namespace Decorator
{
    class ProxyInternetAdressRequester : IRequester
    {
        private InternetAdressRequester adressRequester;

        public ProxyInternetAdressRequester(InternetAdressRequester adressRequester)
        {
            this.adressRequester = adressRequester;
        }

        public void Request()
        {
            adressRequester.Adress = "Proxy: true" + adressRequester.Adress;
            adressRequester.Request();
        }
    }
}
