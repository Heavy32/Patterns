
namespace Factory.AbstractFactory
{
    public class HeavyTankFactory : TankFactory
    {
        public override Armor CreateArmor()
        {
            return new HeavyArmor();
        }

        public override Engine CreateEngine()
        {
            return new HeavyTrackEngine();
        }

        public override Weapon CreateWeapon()
        {
            return new BigGun();
        }
    }
}
