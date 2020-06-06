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
            WebRequest webRequest = new Proxy().Create();
        }
    }
}
