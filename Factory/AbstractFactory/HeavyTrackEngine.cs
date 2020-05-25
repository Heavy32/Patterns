using System;

namespace Factory.AbstractFactory
{
    public class HeavyTrackEngine : Engine
    {
        public override void Move()
        {
            Console.WriteLine("The most powerful engine");
        }
    }
}
