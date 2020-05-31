using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccountFactory vipAccountFactory = new VipAccountFactory("Tom", 20, "King.jpeg");
            Account vipAccount = vipAccountFactory.Create();

            Tank heavyTank = new Tank(new HeavyTankFactory());
            heavyTank.Weapon.Shoot();
            heavyTank.Armor.Deflect();
            heavyTank.Engine.Move();

            Tank swagTank = new Tank(new SwagTank());
            swagTank.Weapon.Shoot();
            swagTank.Armor.Deflect();
            swagTank.Engine.Move();
        }
    }
}
