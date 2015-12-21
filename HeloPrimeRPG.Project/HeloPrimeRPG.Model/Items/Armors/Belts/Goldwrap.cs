using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Belts
{
    using Interfaces;

    public class Goldwrap : Armor, IStrength, IDexterity
    {
        private const ArmorTypes GoldwrapArmourType = ArmorTypes.Belt;
        private const decimal GoldwrapPrice = 1500m;
        private const double GoldwrapWeight = 5;
        private const int GoldwrapProtection = 75;
        private const int GoldwrapStrengthBonus = 20;
        private const int GoldwrapDexterityBonus = 20;

        public Goldwrap(string id, int strenghtBonus = GoldwrapStrengthBonus, int dexterityBonus = GoldwrapDexterityBonus) 
            : base(id, GoldwrapPrice, GoldwrapWeight, GoldwrapProtection, GoldwrapArmourType)
        {
            this.Strength = strenghtBonus;
            this.Dexterity = dexterityBonus;
        }

        public int Strength { get; private set; }

        public int Dexterity { get; private set; }
    }
}
