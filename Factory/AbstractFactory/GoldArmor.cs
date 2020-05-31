using System;

namespace Factory
{
    public class GoldArmor : Armor
    {
        public override void Deflect()
        {
            Console.WriteLine("Useless but swag armor af");
        }
    }
}
