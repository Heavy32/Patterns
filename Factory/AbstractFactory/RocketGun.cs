using System;

namespace Factory
{
    public class RocketGun : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("vsh vsh vsh vsh.....");
        }
    }
}
