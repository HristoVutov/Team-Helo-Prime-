using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Swords
{
    using Interfaces;

    public class MonsterHunter : Weapon, IStrength
    {
        private const WeaponTypes MonsterHunterWeaponType = WeaponTypes.Sword;
        private const WeaponKind MonsterHunterWeaponKind = WeaponKind.OneHanded;
        private const decimal MonsterHunterPrice = 4500m;
        private const double MonsterHunterWeight = 25;
        private const int MonsterHunterDamage = 120;
        private const int MonsterHunterStrengthBonus = 50;

        protected MonsterHunter(string id, int strengthBonus = MonsterHunterStrengthBonus) 
            : base(id, MonsterHunterPrice, MonsterHunterWeight, MonsterHunterDamage, MonsterHunterWeaponType, MonsterHunterWeaponKind)
        {
            this.Strength = strengthBonus;
        }

        public int Strength { get; private set; }
    }
}
