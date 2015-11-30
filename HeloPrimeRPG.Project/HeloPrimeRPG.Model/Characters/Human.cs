﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    public class Human : Character
    {
        private const int DefaultHealth = 400;
        private const int DefaultAttack = 350;
        private const int DefaultDefense = 250;
        private const int DefaultStamina = 250;
        private const int DefaultRange = 4;

        public Human(string id, int x, int y) 
            : base(id, x, y, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
        }
        
    }
}