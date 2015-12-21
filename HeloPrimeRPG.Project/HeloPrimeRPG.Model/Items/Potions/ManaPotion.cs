using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Potions
{
    public class ManaPotion : Potion
    {
        private const PotionType PotionType = Potions.PotionType.ManaPotion;

        public ManaPotion(string id, decimal price, double weight, int bonus)
            : base(id, price, weight, bonus, PotionType)
        {
        }
    }
}
