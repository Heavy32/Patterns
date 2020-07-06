using System.Net;

namespace Proxy
{
    class WebRequstProxy : WebRequest
    {
        private readonly WebRequest request;

        public WebRequstProxy(WebRequest request)
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
