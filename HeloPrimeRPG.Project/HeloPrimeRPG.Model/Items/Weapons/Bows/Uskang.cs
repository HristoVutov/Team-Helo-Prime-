using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Bows
{
    using Interfaces;

    public class Uskang : Weapon, IDexterity, IRange
    {
        private const WeaponTypes UskangWeaponType = WeaponTypes.Bow;
        private const WeaponKind UskangWeaponKind = WeaponKind.Ranged;
        private const decimal UskangPrice = 4500m;
        private const double UskangWeight = 25;
        private const int UskangDamage = 90;
        private const int UskangRange = 100;
        private const int UskangDexterityBonus = 50;

        protected Uskang(string id, int range = UskangRange, int dexterityBonus = UskangDexterityBonus) 
            : base(id, UskangPrice, UskangWeight, UskangDamage, UskangWeaponType, UskangWeaponKind)
        {
            this.Dexterity = dexterityBonus;
            this.Range = range;
        }

        public int Dexterity { get; private set; }

        public int Range { get; private set; }
    }
}
