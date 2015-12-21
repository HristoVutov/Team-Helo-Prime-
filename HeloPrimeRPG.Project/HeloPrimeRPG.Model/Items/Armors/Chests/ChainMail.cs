using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Armors.Chests
{
    public class ChainMail : Armor
    {
        private const ArmorTypes ChainMailArmourType = ArmorTypes.Chest;
        private const decimal ChainMailPrice = 750m;
        private const double ChainMailWeight = 35;
        private const int ChainMailProtection = 45;


        public ChainMail(string id) 
            : base(id, ChainMailPrice, ChainMailWeight, ChainMailProtection, ChainMailArmourType)
        {
        }
    }
}
