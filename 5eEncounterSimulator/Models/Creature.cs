using _5eEncounterSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eEncounterSimulator
{
    public class Creature
    {
        public Creature(string name, string size, string type, string alignment, int armorClass, int maxHitPoints, int currentHitPoints, int hitDice, int speed, int flySpeed, int str, int dex, int con, int intelligence, int wis, int cha, List<AbilityModifier> savingThrows, List<Skill> skills, List<Condition> conditionImmunities, List<Sense> senses, List<string> language, double challenge, List<Property> properties)
        {
            this.Name = name;
            this.Size = size;
            this.Type = type;
            this.Alignment = alignment;
            this.ArmorClass = armorClass;
            this.MaxHitPoints = maxHitPoints;
            this.CurrentHitPoints = currentHitPoints;
            this.HitDice = hitDice;
            this.Speed = speed;
            this.FlySpeed = flySpeed;
            this.Str = str;
            this.StrMod = (str - 10) / 2;
            this.Dex = dex;
            this.DexMod = (dex - 10) / 2;
            this.Con = con;
            this.ConMod = (con - 10) / 2;
            this.Int = intelligence;
            this.IntMod = (intelligence - 10) / 2;
            this.Wis = wis;
            this.WisMod = (wis - 10) / 2;
            this.Cha = cha;
            this.ChaMod = (cha - 10) / 2;
            this.SavingThrows = savingThrows;
            this.Skills = skills;
            this.ConditionImmunities = conditionImmunities;
            this.Senses = senses;
            this.Language = language;
            this.Challenge = challenge;
            this.Properties = properties;
        }

        public string Name;

        public string Size;

        public string Type;

        public string Alignment;

        public int ArmorClass;

        public int MaxHitPoints;

        public int CurrentHitPoints;

        public int HitDice;

        public int Speed;

        public int FlySpeed;

        public int Str;

        public int StrMod;

        public int Dex;

        public int DexMod;

        public int Con;

        public int ConMod;

        public int Int;

        public int IntMod;

        public int Wis;

        public int WisMod;

        public int Cha;

        public int ChaMod;

        public List<AbilityModifier> SavingThrows;

        public List<Skill> Skills;

        public List<Condition> ConditionImmunities;

        public List<Sense> Senses;

        public List<string> Language;

        public double Challenge;

        public List<Property> Properties;

        public List<Action> Actions;

        public List<Attack> Attacks;
    }
}
