using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Bracers
{
    public class LeatherCuffs : Armor
    {
        private const ArmorTypes LeatherCuffsArmourType = ArmorTypes.Bracers;
        private const decimal LeatherCuffsPrice = 50m;
        private const double LeatherCuffsWeight = 4;
        private const int LeatherCuffsProtection = 15;


        public LeatherCuffs(string id) 
            : base(id, LeatherCuffsPrice, LeatherCuffsWeight, LeatherCuffsProtection, LeatherCuffsArmourType)
        {
        }
    }
}
