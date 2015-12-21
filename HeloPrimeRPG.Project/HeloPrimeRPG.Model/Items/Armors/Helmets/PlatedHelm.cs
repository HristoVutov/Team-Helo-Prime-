using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Helmets
{
    public class PlatedHelm : Armor
    {
        private const ArmorTypes PlatedHelmArmourType = ArmorTypes.Helmet;
        private const decimal PlatedHelmPrice = 750m;
        private const double PlatedHelmWeight = 15;
        private const int PlatedHelmProtection = 30;


        public PlatedHelm(string id) 
            : base(id, PlatedHelmPrice, PlatedHelmWeight, PlatedHelmProtection, PlatedHelmArmourType)
        {
        }

    }
}
