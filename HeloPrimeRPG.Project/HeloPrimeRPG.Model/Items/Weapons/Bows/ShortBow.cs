using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Bows
{
    using Interfaces;

    public class ShortBow : Weapon, IRange
    {
        private const WeaponTypes ShortBowWeaponType = WeaponTypes.Bow;
        private const WeaponKind ShortBowWeaponKind = WeaponKind.Ranged;
        private const decimal ShortBowPrice = 500m;
        private const double ShortBowWeight = 15;
        private const int ShortBowDamage = 30;
        private const int ShortBowRange = 30;

        protected ShortBow(string id, int range = ShortBowRange) 
            : base(id, ShortBowPrice, ShortBowWeight, ShortBowDamage, ShortBowWeaponType, ShortBowWeaponKind)
        {
            this.Range = range;
        }

        public int Range { get; private set; }
    }
}
