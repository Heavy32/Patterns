namespace Factory
{
    public class Tank 
    {
        private readonly Weapon weapon;
        private readonly Armor armor;
        private readonly Engine engine;

        public Tank(TankFactory tankFactory)
        {
            weapon = tankFactory.CreateWeapon();
            armor = tankFactory.CreateArmor();
            engine = tankFactory.CreateEngine();
        }

        public Weapon Weapon => weapon;
        public Armor Armor => armor;
        public Engine Engine => engine;
    }
}
