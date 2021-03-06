﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    using Interfaces;
    using Microsoft.Xna.Framework;

    public class Elf : Character, ISpell
    {
        private const int DefaultHealth = 500;
        private const int DefaultAttack = 200;
        private const int DefaultDefense = 200;
        private const int DefaultMana = 300;
        private const int DefaultStamina = 500;
        private const int DefaultRange = 8;

        public Elf(string id, Vector2 position) 
            : base(id, position, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
            this.Mana = DefaultMana;
        }
        
        public int Mana { get; set; }
    }
}
