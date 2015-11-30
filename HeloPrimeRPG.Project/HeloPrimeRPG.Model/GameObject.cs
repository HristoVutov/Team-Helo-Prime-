using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model
{
    public abstract class GameObject
    {
        protected GameObject(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }
    }
}
