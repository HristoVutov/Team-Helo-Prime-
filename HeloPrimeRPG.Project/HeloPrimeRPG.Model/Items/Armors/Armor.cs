using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items
{
    using Armors;

    public abstract class Armor : Item
    {
        private int protection;
        
        protected Armor(string id, decimal price, double weight, int protection, ArmorTypes type)
            : base(id, price, weight)
        {
            this.Protection = protection;
            this.ArmourType = type;
        }

        public int Protection
        {
            get { return this.protection; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Protection cannot be negative");
                }
                this.protection = value;
            }
        }


        public ArmorTypes ArmourType { get; set; }


        //private int armorProtection;

        //public Armor(string weapon, string armor)
        //    : base(weapon, armor)
        //{
        //    this.ArmorProtection = armorProtection;
        //}

        //public int ArmorProtection
        //{
        //    get { return this.armorProtection; }

        //    set { this.armorProtection = value; }
        //}

        //public ArmorTypes ArmorType { get; private set; }

        //public override string ToString()
        //{
        //var print = new StringBuilder();

        //print.AppendFormat("{0} - {1} \r\nStats \r\nDamage: {2}", this.ArmorType, this.Description, this.ArmorProtection);
        //print.Append(base.ToString());

        //return print.ToString();


        
    }
}
