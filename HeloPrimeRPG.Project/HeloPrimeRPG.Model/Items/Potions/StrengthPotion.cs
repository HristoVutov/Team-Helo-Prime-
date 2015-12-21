using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Potions
{
    public class StrengthPotion : Potion
    {
        private const PotionType PotionType = Potions.PotionType.StrengthPotion;

        public StrengthPotion(string id, decimal price, double weight, int bonus)
            : base(id, price, weight, bonus, PotionType)
        {
        }
    }
}
