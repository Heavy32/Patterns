namespace Factory
{
    public abstract class TankFactory
    {
        public abstract Weapon CreateWeapon();
        public abstract Armor CreateArmor();
        public abstract Engine CreateEngine();
    }
}
