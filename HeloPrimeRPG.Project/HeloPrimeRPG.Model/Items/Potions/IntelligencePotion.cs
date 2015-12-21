using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Potions
{
    public class IntelligencePotion : Potion
    {
        private const PotionType PotionType = Potions.PotionType.IntelligencePotion;

        public IntelligencePotion(string id, decimal price, double weight, int bonus)
            : base(id, price, weight, bonus, PotionType)
        {
        }
    }
}
