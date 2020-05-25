using System;

namespace Factory.AbstractFactory
{
    public class GoldArmor : Armor
    {
        public override void Deflect()
        {
            Console.WriteLine("Useless but swag armor af");
        }
    }
}
