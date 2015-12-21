using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Gloves
{
    using Interfaces;

    public class GlovesOfWarship : Armor, IDexterity, IIntelligence
    {
        private const ArmorTypes GlovesOfWarshipArmourType = ArmorTypes.Gloves;
        private const decimal GlovesOfWarshipPrice = 1700m;
        private const double GlovesOfWarshipWeight = 15;
        private const int GlovesOfWarshipProtection = 50;
        private const int GlovesOfWarshipDexterityBonus = 25;
        private const int GlovesOfWarshipIntelligenceBonus = 55;


        public GlovesOfWarship(string id, int dexterityBonus = GlovesOfWarshipDexterityBonus, int intelligenceBonus = GlovesOfWarshipIntelligenceBonus) 
            : base(id, GlovesOfWarshipPrice, GlovesOfWarshipWeight, GlovesOfWarshipProtection, GlovesOfWarshipArmourType)
        {
            this.Dexterity = dexterityBonus;
            this.Intelligence = intelligenceBonus;
        }

        public int Dexterity { get; private set; }
        public int Intelligence { get; private set; }
    }
}
