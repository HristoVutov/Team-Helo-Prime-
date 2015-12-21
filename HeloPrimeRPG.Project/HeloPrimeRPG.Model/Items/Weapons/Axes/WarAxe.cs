using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Axes
{
    using Armors;

    public abstract class WarAxe : Weapon
    {
        private const WeaponTypes WarAxeWeaponType = WeaponTypes.Axe;
        private const WeaponKind WarAxeWeaponKind = WeaponKind.TwoHanded;
        private const decimal WarAxePrice = 950m;
        private const double WarAxeWeight = 25;
        private const int WarAxeDamage = 40;

        protected WarAxe(string id) 
            : base(id, WarAxePrice, WarAxeWeight, WarAxeDamage, WarAxeWeaponType, WarAxeWeaponKind)
        {
        }
    }
}
