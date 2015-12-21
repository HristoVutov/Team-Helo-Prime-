using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Potions
{
    public class DexterityPotion : Potion
    {
        private const PotionType PotionType = Potions.PotionType.DexterityPotion;

        public DexterityPotion(string id, decimal price, double weight, int bonus)
            : base(id, price, weight, bonus, PotionType)
        {
        }
    }
}
