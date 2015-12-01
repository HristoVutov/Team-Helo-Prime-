using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    using Microsoft.Xna.Framework;

    public class Human : Character
    {
        private const int DefaultHealth = 400;
        private const int DefaultAttack = 350;
        private const int DefaultDefense = 250;
        private const int DefaultStamina = 250;
        private const int DefaultRange = 4;

        public Human(string id, Vector2 position) 
            : base(id, position, DefaultHealth, DefaultAttack, DefaultDefense, DefaultStamina, DefaultRange)
        {
        }
        
    }
}
