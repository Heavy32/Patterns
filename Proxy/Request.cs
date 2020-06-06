using System.Net;

namespace Proxy
{
    public class Request : WebRequest
    {
        public HttpWebRequest RequestWithProxy()
        {
            WebRequest request = Create("https://docs.microsoft.com");
            request.Headers["Proxied"] = "true";
            return (HttpWebRequest)request;
        }
    }
}
