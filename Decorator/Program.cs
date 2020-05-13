using System;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBox messageBox = new MessageBox
            {
                Text = "I love you <3"
            };

            Console.WriteLine(messageBox.Text);
        }
    }   
}
