using System;

namespace Factory
{
    public class HeavyTrackEngine : Engine
    {
        public override void Move()
        {
            Console.WriteLine("The most powerful engine");
        }
    }
}
