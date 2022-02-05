using ObjectWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectWar
{
    public class Fight
    {
        private Soldier _soldier;
        private Weapon _weapon;

        public Fight()
        {

        }

        public Fight(Soldier soldier, Weapon weapon)
        {
            _soldier = soldier;
            _weapon = weapon;
        }

        public void FightScore(Soldier s1, Soldier s2)
        {

            s1.IsAlive = true;
            s2.IsAlive = true;

            if (s1.Weapon.WeaponHitPoint > s2.Weapon.WeaponHitPoint)
            {
                
                for (int i = 0; i < s2.Health; i++)
                {
                    s2.Health -= s1.Weapon.WeaponHitPoint;
                    s1.Health -= s2.Weapon.WeaponHitPoint;
                    if (s2.Health == 0)
                    {
                        Console.WriteLine(s1.Name + " KAZANDI" +" " +" Can: " + s1.Health);
                        Console.WriteLine(s2.Name + " KAYBETTİ" + " "+" Can: " + s2.Health);
                    }
                }
            }
            else if (s2.Weapon.WeaponHitPoint > s1.Weapon.WeaponHitPoint)
            {
                for (int i = 0; i < s1.Health; i++)
                {
                    s1.Health -= s2.Weapon.WeaponHitPoint;
                    s2.Health -= s1.Weapon.WeaponHitPoint;
                    if (s1.Health == 0)
                    {
                        Console.WriteLine(s2.Name + " KAZANDI" + " " + "Can: " + s2.Health);
                        Console.WriteLine(s1.Name + " KAYBETTİ" + " " + "Can: " + s1.Health);
                    }
                }

            }
            else
            {
                Console.WriteLine("SAVAŞIN KAZANANI OLMAZ");
            }

        }

        //if (s1.Weapon.WeaponHitPoint>s2.Armor)
        //{
        //    s1.IsAlive = true;
        //    if (s1.IsAlive==true)
        //    {
        //        Console.WriteLine("Kazandı: " + s1.Name);
        //    }
        //    s2.IsAlive = false;
        //    if (s2.IsAlive== false)
        //    {
        //        Console.WriteLine("Kaybetti:" + s2.Name);
        //    }
        //}

        //else if (s2.Weapon.WeaponHitPoint > s1.Armor)
        //{
        //    s2.IsAlive = true;
        //    if (s2.IsAlive == true)
        //    {
        //        Console.WriteLine("Kazandı: " + s2.Name);
        //    }
        //    s1.IsAlive = false;
        //    if (s1.IsAlive==false)
        //    {
        //        Console.WriteLine("Kaybetti: " + s1.Name);
        //    }
        //}

    }

}

