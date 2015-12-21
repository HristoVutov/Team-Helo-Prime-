using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Crossbows
{
    using Interfaces;

    public class DemonMachine : Weapon, IRange, IDexterity, IIntelligence
    {
        private const WeaponTypes DemonMachineWeaponType = WeaponTypes.Crossbow;
        private const WeaponKind DemonMachineWeaponKind = WeaponKind.Ranged;
        private const decimal DemonMachinePrice = 5100m;
        private const double DemonMachineWeight = 35;
        private const int DemonMachineDamage = 150;
        private const int DemonMachineRange = 200;
        private const int DemonMachineDexterityBonus = 40;
        private const int DemonMachineIntelligenceBonus = 40;

        protected DemonMachine(string id, int range = DemonMachineRange, int dexterityBonus = DemonMachineDexterityBonus, int intelligenceBonus = DemonMachineIntelligenceBonus) 
            : base(id, DemonMachinePrice, DemonMachineWeight, DemonMachineDamage, DemonMachineWeaponType, DemonMachineWeaponKind)
        {
            this.Range = range;
            this.Dexterity = dexterityBonus;
            this.Intelligence = intelligenceBonus;
        }

        public int Range { get; private set; }

        public int Dexterity { get; private set; }

        public int Intelligence { get; private set; }
    }
}
