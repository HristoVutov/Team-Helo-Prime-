using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Staffs
{
    using Interfaces;

    public class FjordCutter : Weapon, IRange, IIntelligence
    {
        private const WeaponTypes FjordCutterWeaponType = WeaponTypes.Staff;
        private const WeaponKind FjordCutterWeaponKind = WeaponKind.Ranged;
        private const decimal FjordCutterPrice = 3500m;
        private const double FjordCutterWeight = 15;
        private const int FjordCutterDamage = 55;
        private const int FjordCutterRange = 100;
        private const int FjordCutterIntelligenceBonus = 50;

        protected FjordCutter(string id, int range = FjordCutterRange, int intelligenceBonus = FjordCutterIntelligenceBonus) 
            : base(id, FjordCutterPrice, FjordCutterWeight, FjordCutterDamage, FjordCutterWeaponType, FjordCutterWeaponKind)
        {
            this.Range = range;
            this.Intelligence = intelligenceBonus;
        }

        public int Range { get; private set; }

        public int Intelligence { get; private set; }
    }
}
