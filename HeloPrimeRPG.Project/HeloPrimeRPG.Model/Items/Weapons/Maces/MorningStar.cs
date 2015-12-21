using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Maces
{
    public class MorningStar : Weapon
    {
        private const WeaponTypes MorningStarWeaponType = WeaponTypes.Mace;
        private const WeaponKind MorningStarWeaponKind = WeaponKind.OneHanded;
        private const decimal MorningStarPrice = 1200m;
        private const double MorningStarWeight = 25;
        private const int MorningStarDamage = 35;

        protected MorningStar(string id) 
            : base(id, MorningStarPrice, MorningStarWeight, MorningStarDamage, MorningStarWeaponType, MorningStarWeaponKind)
        {
        }
    }
}
