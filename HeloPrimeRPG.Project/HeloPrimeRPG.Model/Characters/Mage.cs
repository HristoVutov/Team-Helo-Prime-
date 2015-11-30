using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    using Interfaces;

    public class Mage : Character, ISpell
    {
        private const int DefaultHealth = 200;
        private const int DefaultAttack = 200;
        private const int DefaultDefense = 150;
        private const int DefaultMana = 500;
        private const int DefaultStamina = 250;
        private const int DefaultRange = 10;

        public Mage(string id, int x, int y) 
            : base(id, x, y, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
            this.Mana = DefaultMana;
        }
        
        public int Mana { get; set; }
    }
}
