using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items
{
    using Weapons;

    public abstract class Weapon : Item
    {
        private int damage;

        protected Weapon(string id, decimal price, double weight, int damage, WeaponTypes type, WeaponKind kind)
            : base(id, price, weight)
        {
            this.Damage = damage;
            this.WeaponType = type;
            this.WeaponKind = kind;
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Damage cannot be negative");
                }
                this.damage = value;
            }
        }


        public WeaponTypes WeaponType { get; private set; }


        public WeaponKind WeaponKind { get; private set; }


        //protected Weapon(string weapon, string armor, WeaponTypes weaponType)
        //        : base(weapon, armor)
        //{
        //    this.WeaponDamage = weaponDamage;
        //    this.WeaponAttack = weaponAttack;
        //}


        //public int WeaponDamage
        //{
        //    get { return this.weaponDamage; }

        //    set { this.weaponDamage = value; }
        //}

        //public int WeaponAttack
        //{
        //    get { return this.weaponAttack; }

        //    set { this.weaponAttack = value; }
        //}

        //public WeaponTypes WeaponType { get; private set; }

        //public override string ToString()
        //{
        //    var print = new StringBuilder();

        //    print.AppendFormat("{0} - {1} \r\nStats \r\nDamage: {2}", this.WeaponType, this.Description, this.WeaponDamage);

        //    print.Append(base.ToString());

        //    return print.ToString();
        //}


        
    }

}
