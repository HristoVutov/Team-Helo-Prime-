using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Interfaces
{
    public interface IStatable
    {
        int Stamina { get; set; }

        int Agility { get; set; }

        int Strength { get; set; }

        int Intellect { get; set; }
    }
}
