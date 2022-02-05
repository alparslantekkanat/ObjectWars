using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWars
{
    public class Weapon
    {
        public Weapon()
        {

        }

        public Weapon(string weaponName, int weaponHitPoint, int shotGroup)
        {
            WeaponName = weaponName;
            WeaponHitPoint = weaponHitPoint;
            ShotGroup = shotGroup;
        }
        public Weapon(string weaponName, int weaponHitPoint)
        {
            WeaponName = weaponName;
            WeaponHitPoint = weaponHitPoint;
        }

        public string WeaponName { get; set; }
        public int WeaponHitPoint { get; set; }
        public int ShotGroup { get; set; }
    }
}
