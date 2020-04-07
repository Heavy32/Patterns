using System;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMeal meal = new Potato(new Fish());          
        }
    }   
}
