using System.Net;

namespace Proxy
{
    class Proxy : WebRequest
    {
        private readonly Request request;

        public Proxy()
        {
            request = new Request();
        }

        public WebRequest Create()
        {
            return request.RequestWithProxy();
        }
    }
}
