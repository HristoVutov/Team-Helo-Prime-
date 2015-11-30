using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model
{
    public class Skill
    {
        public Skill(int SkillID, double CoolDownInSeconds, Effect Effect, string EffectDescription, double ManaRequrired, double EffectForSeconds = 0, double EffectDamage = 0)
        {
            this.SkillID = SkillID;
            this.CoolDownInSeconds = CoolDownInSeconds;
            this.Effect = Effect;
            this.EffectDamage = EffectDamage;
            this.EffectDescription = EffectDescription;
            this.EffectForSeconds = EffectForSeconds;
            this.ManaRequrired = ManaRequrired;
        }

        public int SkillID { get; set; }

        public double CoolDownInSeconds { get; set; }

        public Effect Effect { get; set; }

        public string EffectDescription { get; set; }

        public double EffectForSeconds { get; set; }

        public double EffectDamage { get; set; }

        public double ManaRequrired { get; set; }
    }
}
