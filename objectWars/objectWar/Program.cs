using objectWar;
using System;

namespace ObjectWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon gun01 = new Weapon("AK47", 25, 20);
            Weapon gun02 = new Weapon("Pump", 20, 10);
            Weapon gun03 = new Weapon("Gun", 10, 7);
            Weapon knife01 = new Weapon("Knife", 5);

            Soldier soldier01 = new Soldier(5, gun01, true,"Soldier1");
            Soldier soldier02 = new Soldier(5, gun02, true,"Soldier2");

            Fight fight = new Fight();
            fight.FightScore(soldier01, soldier02);



        }
    }
}
