using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Boots
{
    public class Boots : Armor
    {
        private const ArmorTypes BootsArmourType = ArmorTypes.Boots;
        private const decimal BootsPrice = 70m;
        private const double BootsWeight = 10;
        private const int BootsProtection = 30;

        public Boots(string id) 
            : base(id, BootsPrice, BootsWeight, BootsProtection, BootsArmourType)
        {
        }

    }
}
