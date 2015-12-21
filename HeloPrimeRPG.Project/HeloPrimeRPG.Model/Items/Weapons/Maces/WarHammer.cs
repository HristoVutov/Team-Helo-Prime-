using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Maces
{
    public class WarHammer : Weapon
    {
        private const WeaponTypes WarHammerWeaponType = WeaponTypes.Mace;
        private const WeaponKind WarHammerWeaponKind = WeaponKind.TwoHanded;
        private const decimal WarHammerPrice = 2300m;
        private const double WarHammerWeight = 35;
        private const int WarHammerDamage = 45;

        protected WarHammer(string id) 
            : base(id, WarHammerPrice, WarHammerWeight, WarHammerDamage, WarHammerWeaponType, WarHammerWeaponKind)
        {
        }
    }
}
