using System.Net;

namespace Proxy
{
    class Proxy : WebRequest
    {
        private readonly WebRequest request;

        public Proxy(WebRequest request)
        {
            this.request = request;
        }

        public WebRequest Create()
        {
            WebRequest request = Create("https://docs.microsoft.com");
            request.Headers["Proxied"] = "true";
            return (HttpWebRequest)request;
        }
    }
}
