using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Axes
{
    using Interfaces;

    public class TheExecutioner : Weapon, IStrength
    {
        private const WeaponTypes TheExecutionerWeaponType = WeaponTypes.Axe;
        private const WeaponKind TheExecutionerWeaponKind = WeaponKind.TwoHanded;
        private const decimal TheExecutionerPrice = 4500m;
        private const double TheExecutionerWeight = 45;
        private const int TheExecutionerDamage = 200;
        private const int TheExecutionerStrengthBonus = 50;

        protected TheExecutioner(string id, int strengthBonus = TheExecutionerStrengthBonus) 
            : base(id, TheExecutionerPrice, TheExecutionerWeight, TheExecutionerDamage, TheExecutionerWeaponType, TheExecutionerWeaponKind)
        {
            this.Strength = strengthBonus;
        }

        public int Strength { get; private set; }
    }
}
