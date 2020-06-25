using System;

namespace Factory
{
    public class HeavyArmor : Armor
    {
        public override void Deflect()
        {
            Console.WriteLine("No damage recieved");
        }
    }
}
