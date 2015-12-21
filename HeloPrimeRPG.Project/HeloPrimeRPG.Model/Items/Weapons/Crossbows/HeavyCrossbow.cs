using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Crossbows
{
    using Interfaces;

    public class HeavyCrossbow : Weapon, IRange
    {
        private const WeaponTypes HeavyCrossbowWeaponType = WeaponTypes.Crossbow;
        private const WeaponKind HeavyCrossbowWeaponKind = WeaponKind.Ranged;
        private const decimal HeavyCrossbowPrice = 2100m;
        private const double HeavyCrossbowWeight = 55;
        private const int HeavyCrossbowDamage = 90;
        private const int HeavyCrossbowRange = 100;

        protected HeavyCrossbow(string id, int range = HeavyCrossbowRange) 
            : base(id, HeavyCrossbowPrice, HeavyCrossbowWeight, HeavyCrossbowDamage, HeavyCrossbowWeaponType, HeavyCrossbowWeaponKind)
        {
            this.Range = range;
        }

        public int Range { get; private set; }
    }
}
