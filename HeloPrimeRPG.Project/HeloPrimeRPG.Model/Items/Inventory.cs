using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeloPrimeRPG.Model.Interfaces;

namespace HeloPrimeRPG.Model.Items
{
    public class Inventory : Item, IEffectable
    {
        private ICollection<Item> heroItems;


        public Inventory(string weapon, string armor)
            : base(weapon, armor)
        {
            this.HeroItems = new List<Item>();
        }

        public int HealthGained { get; set; }
        public int EnergyGained { get; set; }


        private IEnumerable<Item> HeroItems { get; set; }

    }
}
