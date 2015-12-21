using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Pants
{
    public class ChainLeggings : Armor
    {
        private const ArmorTypes ChainLeggingsArmourType = ArmorTypes.Pants;
        private const decimal ChainLeggingsPrice = 950m;
        private const double ChainLeggingsWeight = 20;
        private const int ChainLeggingsProtection = 40;


        public ChainLeggings(string id) 
            : base(id, ChainLeggingsPrice, ChainLeggingsWeight, ChainLeggingsProtection, ChainLeggingsArmourType)
        {
        }
    }
}
