using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Bracers
{
    using Interfaces;

    public class SteadyStrikers : Armor, IStrength
    {
        private const ArmorTypes SteadyStrikersArmourType = ArmorTypes.Bracers;
        private const decimal SteadyStrikersPrice = 2500m;
        private const double SteadyStrikersWeight = 10;
        private const int SteadyStrikersProtection = 75;
        private const int SteadyStrikersStrengthBonus = 45;

        public SteadyStrikers(string id, int strengthBonus = SteadyStrikersStrengthBonus) 
            : base(id, SteadyStrikersPrice, SteadyStrikersWeight, SteadyStrikersProtection, SteadyStrikersArmourType)
        {
            this.Strength = strengthBonus;
        }

        public int Strength { get; private set; }
    }
}
