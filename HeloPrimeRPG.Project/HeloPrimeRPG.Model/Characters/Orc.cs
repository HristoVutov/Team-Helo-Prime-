using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    public class Orc : Character
    {
        private const int DefaultHealth = 350;
        private const int DefaultAttack = 500;
        private const int DefaultDefense = 300;
        private const int DefaultStamina = 300;
        private const int DefaultRange = 4;

        public Orc(string id, int x, int y) 
            : base(id, x, y, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
        }
        
    }
}
