using System;

namespace Factory
{
    public class NuclearEngine : Engine
    {
        public override void Move()
        {
            Console.WriteLine("Eco-clean and safe engine");
        }
    }
}
