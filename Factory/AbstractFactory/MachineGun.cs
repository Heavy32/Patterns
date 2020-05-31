using System;

namespace Factory
{
    public class MachineGun : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Ratatatatatatatatata");
        }
    }
}
