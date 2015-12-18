using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items
{
    public class Armor : ItemState
    {
        private int armorProtection;

        public Armor(string weapon, string armor)
            : base(weapon, armor)
        {
            this.ArmorProtection = armorProtection;
        }

        public int ArmorProtection
        {
            get { return this.armorProtection; }

            set { this.armorProtection = value; }
        }

        public ArmorTypes ArmorType { get; private set; }

        //public override string ToString()
        //{
        //var print = new StringBuilder();

        //print.AppendFormat("{0} - {1} \r\nStats \r\nDamage: {2}", this.ArmorType, this.Description, this.ArmorProtection);
        //print.Append(base.ToString());

        //return print.ToString();

    }
}
}
