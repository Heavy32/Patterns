using System;

namespace Factory.AbstractFactory
{
    public class BigGun : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("BOOOOOOOOM!");  
        }
    }
}
