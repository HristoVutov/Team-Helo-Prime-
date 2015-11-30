using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    using Interfaces;

    public class Undead : Character, ISpell
    {
        private const int DefaultHealth = 200;
        private const int DefaultAttack = 150;
        private const int DefaultDefense = 200;
        private const int DefaultMana = 100;
        private const int DefaultStamina = 350;
        private const int DefaultRange = 1;

        public Undead(string id, int x, int y) 
            : base(id, x, y, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
            this.Mana = DefaultMana;
        }
        
        public int Mana { get; set; }
    }
}
