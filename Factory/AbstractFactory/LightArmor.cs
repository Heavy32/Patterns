using System;

namespace Factory.AbstractFactory
{
    public class LightArmor : Armor
    {
        public override void Deflect()
        {
            Console.WriteLine("Even a stone can beat you");
        }
    }
}
