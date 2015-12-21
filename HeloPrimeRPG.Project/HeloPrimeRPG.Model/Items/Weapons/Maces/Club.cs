using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Maces
{
    public class Club : Weapon
    {
        private const WeaponTypes ClubWeaponType = WeaponTypes.Mace;
        private const WeaponKind ClubWeaponKind = WeaponKind.OneHanded;
        private const decimal ClubPrice = 70m;
        private const double ClubWeight = 9;
        private const int ClubDamage = 15;

        protected Club(string id) 
            : base(id, ClubPrice, ClubWeight, ClubDamage, ClubWeaponType, ClubWeaponKind)
        {
        }
    }
}
