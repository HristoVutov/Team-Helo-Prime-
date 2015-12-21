using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Items.Weapons.Daggers
{
    public class PidSticker : Weapon
    {
        private const WeaponTypes PidStickerWeaponType = WeaponTypes.Dagger;
        private const WeaponKind PidStickerWeaponKind = WeaponKind.OneHanded;
        private const decimal PidStickerPrice = 100m;
        private const double PidStickerWeight = 7;
        private const int PidStickerDamage = 12;

        protected PidSticker(string id) 
            : base(id, PidStickerPrice, PidStickerWeight, PidStickerDamage, PidStickerWeaponType, PidStickerWeaponKind)
        {
        }

    }
}
