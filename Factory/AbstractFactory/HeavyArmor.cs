using System;

namespace Factory.AbstractFactory
{
    public class HeavyArmor : Armor
    {
        public override void Deflect()
        {
            Console.WriteLine("No damage recieved");
        }
    }
}
