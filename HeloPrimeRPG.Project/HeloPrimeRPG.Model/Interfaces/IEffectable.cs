using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Interfaces
{
    public interface IEffectable
    {
        int HealthGained { get; set; }

        int EnergyGained { get; set; }
    }
}
