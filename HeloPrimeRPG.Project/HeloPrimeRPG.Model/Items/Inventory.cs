using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeloPrimeRPG.Model.Interfaces;

namespace HeloPrimeRPG.Model.Items
{
    public class Inventory
    {
        private ICollection<Item> heroItems;

        public Inventory(IEnumerable<Item> heroItems)
        {
            this.HeroItems = heroItems;
        }
        

        private IEnumerable<Item> HeroItems { get; set; }

    }
}
