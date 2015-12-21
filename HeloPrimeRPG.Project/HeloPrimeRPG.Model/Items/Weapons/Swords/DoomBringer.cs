using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Swords
{
    using Interfaces;

    public class DoomBringer : Weapon, IIntelligence, IVitality
    {
        private const WeaponTypes DoomBringerWeaponType = WeaponTypes.Sword;
        private const WeaponKind DoomBringerWeaponKind = WeaponKind.TwoHanded;
        private const decimal DoomBringerPrice = 7500m;
        private const double DoomBringerWeight = 35;
        private const int DoomBringerDamage = 180;
        private const int DoomBringerIntelligenceBonus = 50;
        private const int DoomBringerHealthBonus = 80;

        protected DoomBringer(string id, int intelligenceBonus = DoomBringerIntelligenceBonus, int healthBonus = DoomBringerHealthBonus) 
            : base(id, DoomBringerPrice, DoomBringerWeight, DoomBringerDamage, DoomBringerWeaponType, DoomBringerWeaponKind)
        {
            this.Intelligence = intelligenceBonus;
            this.HealthBonus = healthBonus;
        }

        public int Intelligence { get; private set; }
        public int HealthBonus { get; private set; }
    }
}
