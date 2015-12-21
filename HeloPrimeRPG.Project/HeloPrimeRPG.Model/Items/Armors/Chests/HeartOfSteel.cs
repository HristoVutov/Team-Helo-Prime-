using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Chests
{
    using Interfaces;

    public class HeartOfSteel : Armor, IStrength, IDexterity, IIntelligence
    {
        private const ArmorTypes HeartOfSteelArmourType = ArmorTypes.Chest;
        private const decimal HeartOfSteelPrice = 2500m;
        private const double HeartOfSteelWeight = 55;
        private const int HeartOfSteelProtection = 100;
        private const int HeartOfSteelStrengthBonus = 75;
        private const int HeartOfSteelDexterityBonus = 75;
        private const int HeartOfSteelIntelligenceBonus = 75;


        public HeartOfSteel(string id, int strengthBonus = HeartOfSteelStrengthBonus, int dexterityBonus = HeartOfSteelDexterityBonus, int intelligenceBonus = HeartOfSteelIntelligenceBonus) 
            : base(id, HeartOfSteelPrice, HeartOfSteelWeight, HeartOfSteelProtection, HeartOfSteelArmourType)
        {
            this.Strength = strengthBonus;
            this.Dexterity = dexterityBonus;
            this.Intelligence = intelligenceBonus;
        }

        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Intelligence { get; private set; }
    }
}
