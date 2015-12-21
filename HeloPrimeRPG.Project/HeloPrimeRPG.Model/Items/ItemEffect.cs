using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeloPrimeRPG.Model.Interfaces;

namespace HeloPrimeRPG.Model.Items
{
    public abstract class ItemEffect : IEffectable
    {

        public abstract int HealthGained { get; set; }
        public abstract int EnergyGained { get; set; }
    }


}
