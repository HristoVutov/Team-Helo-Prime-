using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeloPrimeRPG.Model.Interfaces;

namespace HeloPrimeRPG.Model.Items
{
    public abstract class ItemState : IStatable
    {
        private int stamina;
        private int agility;
        private int strength;
        private int intellect;

        #region Properties
        

        public int Stamina
        {
            get { return this.stamina; }

            set { this.stamina = value; }
        }

        public int Agility
        {
            get { return this.agility; }

            set { this.agility = value; }
        }

        public int Strength
        {
            get { return this.strength; }

            set { this.strength = value; }
        }

        public int Intellect
        {
            get { return this.intellect; }

            set { this.intellect = value; }
        }

        #endregion

        public override string ToString()
        {
            return string.Format("\r\nStamina: {0} \r\nAgility: {1} \r\nStrength: {2} \r\nIntellect: {3}",
                this.Stamina, this.Agility, this.Strength, this.Intellect);
        }


    }
}