using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, int value, int minDamage, int maxDamage, string description, int experiencePoints, string useMessage, string inspect)
            : base(id, name, value, description, experiencePoints, useMessage, inspect)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        public override string InformationString()
        {
            return $"{Name}: {Description}\nDamage: {MinimumDamage}-{MaximumDamage}";
        }
    }
}