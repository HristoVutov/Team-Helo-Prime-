using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Belts
{
    public class Cord : Armor
    {
        private const ArmorTypes CordArmourType = ArmorTypes.Belt;
        private const decimal CordPrice = 50m;
        private const double CordWeight = 4;
        private const int CordProtection = 15;

        public Cord(string id) 
            : base(id, CordPrice, CordWeight, CordProtection, CordArmourType)
        {
        }

    }
}
