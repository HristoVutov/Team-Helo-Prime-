using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Boots
{
    using Interfaces;

    public class Sabatons : Armor, ISpeed
    {
        private const ArmorTypes SabatonssArmourType = ArmorTypes.Boots;
        private const decimal SabatonsPrice = 1800m;
        private const double SabatonsWeight = 15;
        private const int SabatonsProtection = 80;
        private const int SabatonSpeedBonus = 25;

        public Sabatons(string id, int speedBonus = SabatonSpeedBonus) 
            : base(id, SabatonsPrice, SabatonsWeight, SabatonsProtection, SabatonssArmourType)
        {
            this.Speed = speedBonus;
        }

        public int Speed { get; private set; }
    }
}
