using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Bows
{
    using Interfaces;

    public class LongBow : Weapon, IRange
    {
        private const WeaponTypes LongBowWeaponType = WeaponTypes.Bow;
        private const WeaponKind LongBowWeaponKind = WeaponKind.Ranged;
        private const decimal LongBowPrice = 1500m;
        private const double LongBowWeight = 25;
        private const int LongBowDamage = 50;
        private const int LongBowRange = 60;

        protected LongBow(string id, int range = LongBowRange) 
            : base(id, LongBowPrice, LongBowWeight, LongBowDamage, LongBowWeaponType, LongBowWeaponKind)
        {
            this.Range = range;
        }

        public int Range { get; private set; }
    }
}
