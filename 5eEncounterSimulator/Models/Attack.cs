using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eEncounterSimulater.Models
{
    class Attack
    {
        public int DamageDice;

        public string DamageType;

        public int DiceNumber;

        public int DamageModifier;

        public List<Property> AdditionalEffects;

        public bool Melee;

        public bool Ranged;

        public bool Special;

        public int ToHitMod;
    }
}
