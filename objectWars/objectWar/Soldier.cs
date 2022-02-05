using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWars
{
    public class Soldier
    {
        //1. İki asker nesnesi çarpışacak.
        //2. Army isminde bir sınıfınız olsun. Soldiers koleksiyonuna asker eklensin.

        public Soldier(int armor, Weapon weapon, bool isAlive,string name)
        {
            Name = name;
            Armor = armor;
            Weapon = weapon;
            IsAlive = isAlive;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public int Armor { get; set; }

        public Weapon Weapon { get; set; }

        public bool IsAlive { get; set; }
        public void Attack(Soldier enemy, Soldier ourSoldier)
        {
            if (ourSoldier.IsAlive)
            {
                while (enemy.Weapon.WeaponHitPoint > ourSoldier.Armor)
                {
                    ourSoldier.Health -= enemy.Weapon.WeaponHitPoint;
                }

            }
            else
            {
                Console.WriteLine("Savaşacağın asker yooooğğhhk");
            }

        }


    }
}

