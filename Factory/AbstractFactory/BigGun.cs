using System;

namespace Factory
{
    public class BigGun : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("BOOOOOOOOM!");  
        }
    }
}
