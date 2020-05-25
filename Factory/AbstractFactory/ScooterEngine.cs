using System;

namespace Factory.AbstractFactory
{
    public class ScooterEngine : Engine
    {
        public override void Move()
        {
            Console.WriteLine("The lightest engine, but a feeble one");
        }
    }
}
