using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items
{
    public abstract class Weapon : ItemState
    {
        private int weaponDamage;
        private int weaponAttack;


        protected Weapon(string weapon, string armor, WeaponTypes weaponType)
                : base(weapon, armor)
        {
            this.WeaponDamage = weaponDamage;
            this.WeaponAttack = weaponAttack;
        }


        public int WeaponDamage
        {
            get { return this.weaponDamage; }

            set { this.weaponDamage = value; }
        }

        public int WeaponAttack
        {
            get { return this.weaponAttack; }

            set { this.weaponAttack = value; }
        }

        public WeaponTypes WeaponType { get; private set; }

        //public override string ToString()
        //{
        //    var print = new StringBuilder();

        //    print.AppendFormat("{0} - {1} \r\nStats \r\nDamage: {2}", this.WeaponType, this.Description, this.WeaponDamage);

        //    print.Append(base.ToString());

        //    return print.ToString();
        //}


    }

}
