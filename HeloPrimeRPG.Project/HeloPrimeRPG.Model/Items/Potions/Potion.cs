using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Potions
{
    using Interfaces;

    public abstract class Potion : Item, IConsumable
    {
        private int bonus;

        protected Potion(string id, decimal price, double weight, int bonus, PotionType type) 
            : base(id, price, weight)
        {
            this.PotionType = type;
            this.Bonus = bonus;
        }

        public int Bonus
        {
            get { return this.bonus; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Bonus cannot be negative");
                }
                this.bonus = value;
            }
        }

        public PotionType PotionType { get; private set; }
    }
}
