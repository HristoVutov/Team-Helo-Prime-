using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Gloves
{
    public class LeatherGloves : Armor
    {
        private const ArmorTypes LeatherGlovesArmourType = ArmorTypes.Gloves;
        private const decimal LeatherGlovesPrice = 150m;
        private const double LeatherGlovesWeight = 2;
        private const int LeatherGlovesProtection = 10;


        public LeatherGloves(string id) 
            : base(id, LeatherGlovesPrice, LeatherGlovesWeight, LeatherGlovesProtection, LeatherGlovesArmourType)
        {
        }
    }
}
