namespace Factory.AbstractFactory
{
    public class SwagTank : TankFactory
    {
        public override Armor CreateArmor()
        {
            return new GoldArmor();
        }

        public override Engine CreateEngine()
        {
            return new NuclearEngine();
        }

        public override Weapon CreateWeapon()
        {
            return new RocketGun();
        }
    }
}
