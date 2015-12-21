using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Pants
{
    public class LeatherPants : Armor
    {
        private const ArmorTypes LeatherPantsArmourType = ArmorTypes.Pants;
        private const decimal LeatherPantsPrice = 250m;
        private const double LeatherPantsWeight = 10;
        private const int LeatherPantsProtection = 20;


        public LeatherPants(string id) 
            : base(id, LeatherPantsPrice, LeatherPantsWeight, LeatherPantsProtection, LeatherPantsArmourType)
        {
        }
    }
}
