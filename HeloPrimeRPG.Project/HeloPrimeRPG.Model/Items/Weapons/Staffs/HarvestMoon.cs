using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Staffs
{
    using Interfaces;

    public class HarvestMoon : Weapon, IVitality
    {
        private const WeaponTypes HarvestMoonWeaponType = WeaponTypes.Staff;
        private const WeaponKind HarvestMoonWeaponKind = WeaponKind.TwoHanded;
        private const decimal HarvestMoonPrice = 3500m;
        private const double HarvestMoonWeight = 15;
        private const int HarvestMoonDamage = 55;
        private const int HarvestMoonHealthBonus = 40;

        protected HarvestMoon(string id, int healthBonus = HarvestMoonHealthBonus) 
            : base(id, HarvestMoonPrice, HarvestMoonWeight, HarvestMoonDamage, HarvestMoonWeaponType, HarvestMoonWeaponKind)
        {
            this.HealthBonus = healthBonus;
        }

        public int HealthBonus { get; private set; }
    }
}
