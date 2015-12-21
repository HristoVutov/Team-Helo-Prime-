using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Crossbows
{
    using Interfaces;

    public class LightCrossbow : Weapon, IRange
    {
        private const WeaponTypes LightCrossbowWeaponType = WeaponTypes.Crossbow;
        private const WeaponKind LightCrossbowWeaponKind = WeaponKind.Ranged;
        private const decimal LightCrossbowPrice = 1200m;
        private const double LightCrossbowWeight = 35;
        private const int LightCrossbowDamage = 70;
        private const int LightCrossbowRange = 80;

        protected LightCrossbow(string id, int range = LightCrossbowRange) 
            : base(id, LightCrossbowPrice, LightCrossbowWeight, LightCrossbowDamage, LightCrossbowWeaponType, LightCrossbowWeaponKind)
        {
            this.Range = range;
        }

        public int Range { get; private set; }

    }
}
