using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Swords
{
    public class LongSword : Weapon
    {
        private const WeaponTypes LongSwordWeaponType = WeaponTypes.Sword;
        private const WeaponKind LongSwordWeaponKind = WeaponKind.TwoHanded;
        private const decimal LongSwordPrice = 900m;
        private const double LongSwordWeight = 25;
        private const int LongSwordDamage = 55;


        protected LongSword(string id)
            : base(id, LongSwordPrice, LongSwordWeight, LongSwordDamage, LongSwordWeaponType, LongSwordWeaponKind)
        {
            
        }
    }
}
