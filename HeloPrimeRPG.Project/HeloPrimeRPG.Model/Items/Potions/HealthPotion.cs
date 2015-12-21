using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Potions
{
    public class HealthPotion : Potion
    {
        private const PotionType PotionType = Potions.PotionType.HealthPotion;

        public HealthPotion(string id, decimal price, double weight, int bonus)
            : base(id, price, weight, bonus, PotionType)
        {
        }
    }
}
