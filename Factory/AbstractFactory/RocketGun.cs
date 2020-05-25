using System;

namespace Factory.AbstractFactory
{
    public class RocketGun : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("vsh vsh vsh vsh.....");
        }
    }
}
