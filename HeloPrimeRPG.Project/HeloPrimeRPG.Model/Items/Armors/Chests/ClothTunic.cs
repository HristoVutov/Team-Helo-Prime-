using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Chests
{
    public class ClothTunic : Armor
    {
        private const ArmorTypes ClothTunicArmourType = ArmorTypes.Chest;
        private const decimal ClothTunicPrice = 150m;
        private const double ClothTunicWeight = 15;
        private const int ClothTunicProtection = 20;


        public ClothTunic(string id) 
            : base(id, ClothTunicPrice, ClothTunicWeight, ClothTunicProtection, ClothTunicArmourType)
        {
        }
    }
}
