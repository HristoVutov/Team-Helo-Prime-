using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Axes
{
    public class BurstOfWrath : Weapon
    {
        private const WeaponTypes BurstOfWrathWeaponType = WeaponTypes.Axe;
        private const WeaponKind BurstOfWrathWeaponKind = WeaponKind.TwoHanded;
        private const decimal BurstOfWrathPrice = 2100m;
        private const double BurstOfWrathWeight = 35;
        private const int BurstOfWrathDamage = 100;

        protected BurstOfWrath(string id) 
            : base(id, BurstOfWrathPrice, BurstOfWrathWeight, BurstOfWrathDamage, BurstOfWrathWeaponType, BurstOfWrathWeaponKind)
        {
        }
    }
}
