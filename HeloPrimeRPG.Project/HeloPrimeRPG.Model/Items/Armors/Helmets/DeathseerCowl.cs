using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Helmets
{
    using Interfaces;

    public class DeathseerCowl : Armor, IIntelligence
    {
        private const ArmorTypes DeathseerCowlArmourType = ArmorTypes.Helmet;
        private const decimal DeathseerCowlPrice = 2500m;
        private const double DeathseerCowlWeight = 55;
        private const int DeathseerCowlProtection = 100;
        private const int DeathseerCowlIntelligenceBonus = 75;


        public DeathseerCowl(string id, int intelligenceBonus = DeathseerCowlIntelligenceBonus) 
            : base(id, DeathseerCowlPrice, DeathseerCowlWeight, DeathseerCowlProtection, DeathseerCowlArmourType)
        {
            this.Intelligence = intelligenceBonus;
        }

        public int Intelligence { get; private set; }
    }
}
