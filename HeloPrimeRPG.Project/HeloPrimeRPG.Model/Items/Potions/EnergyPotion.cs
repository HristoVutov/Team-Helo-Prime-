using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Potions
{
    public class EnergyPotion : Potion
    {
        private const PotionType PotionType = Potions.PotionType.EnergyPotion;

        public EnergyPotion(string id, decimal price, double weight, int bonus)
            : base(id, price, weight, bonus, PotionType)
        {
        }
    }
}
