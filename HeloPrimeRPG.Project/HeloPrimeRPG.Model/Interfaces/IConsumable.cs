using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Interfaces
{
    using Items.Potions;

    public interface IConsumable
    {
        int Bonus { get; }

        PotionType PotionType { get; }
    }
}
