using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    using Microsoft.Xna.Framework;

    public class Dwarf : Character
    {
        private const int DefaultHealth = 250;
        private const int DefaultAttack = 300;
        private const int DefaultDefense = 450;
        private const int DefaultStamina = 150;
        private const int DefaultRange = 2;

        public Dwarf(string id, Vector2 position) 
            : base(id, position, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
        }
        
    }
}
