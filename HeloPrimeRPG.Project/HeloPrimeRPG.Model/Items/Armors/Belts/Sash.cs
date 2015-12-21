using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Belts
{
    public class Sash : Armor
    {
        private const ArmorTypes SashArmourType = ArmorTypes.Belt;
        private const decimal SashPrice = 10m;
        private const double SashWeight = 2;
        private const int SashProtection = 6;

        public Sash(string id) 
            : base(id, SashPrice, SashWeight, SashProtection, SashArmourType)
        {
        }
    }
}
