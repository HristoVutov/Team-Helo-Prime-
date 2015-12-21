using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Swords
{
    public class ShortSword : Weapon
    {
        private const WeaponTypes ShortSwordWeaponType = WeaponTypes.Sword;
        private const WeaponKind ShortSwordWeaponKind = WeaponKind.OneHanded;
        private const decimal ShortSwordPrice = 200m;
        private const double ShortSwordWeight = 15;
        private const int ShortSwordDamage = 30;


        protected ShortSword(string id) 
            : base(id, ShortSwordPrice, ShortSwordWeight, ShortSwordDamage, ShortSwordWeaponType, ShortSwordWeaponKind)
        {
            
        }
    }
}
