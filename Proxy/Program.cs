using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = (HttpWebRequest)WebRequest.Create("www.google.com");
            WebRequest webRequest = new Proxy(request).Create();
        }
    }
}
