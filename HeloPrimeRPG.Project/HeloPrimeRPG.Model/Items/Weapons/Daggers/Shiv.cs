using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Daggers
{
    public class Shiv : Weapon
    {
        private const WeaponTypes ShivWeaponType = WeaponTypes.Dagger;
        private const WeaponKind ShivWeaponKind = WeaponKind.OneHanded;
        private const decimal ShivPrice = 50m;
        private const double ShivWeight = 5;
        private const int ShivDamage = 7;

        protected Shiv(string id) 
            : base(id, ShivPrice, ShivWeight, ShivDamage, ShivWeaponType, ShivWeaponKind)
        {
        }

       
    }
}
