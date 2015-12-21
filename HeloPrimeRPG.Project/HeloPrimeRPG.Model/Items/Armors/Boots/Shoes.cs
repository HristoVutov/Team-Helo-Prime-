using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Boots
{
    public class Shoes : Armor
    {
        private const ArmorTypes ShoesArmourType = ArmorTypes.Boots;
        private const decimal ShoesPrice = 15m;
        private const double ShoesWeight = 5;
        private const int ShoesProtection = 10;

        public Shoes(string id) 
            : base(id, ShoesPrice, ShoesWeight, ShoesProtection, ShoesArmourType)
        {
        }
    }
}
