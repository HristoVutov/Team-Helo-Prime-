using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    public class Barbarian : Character
    {
        private const int DefaultHealth = 300;
        private const int DefaultAttack = 400;
        private const int DefaultDefense = 400;
        private const int DefaultStamina = 400;
        private const int DefaultRange = 3;

        public Barbarian(string id, int x, int y) 
            : base(id, x, y, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
        }
        
    }
}
