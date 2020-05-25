using System;

namespace Factory.AbstractFactory
{
    public class MachineGun : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Ratatatatatatatatata");
        }
    }
}
