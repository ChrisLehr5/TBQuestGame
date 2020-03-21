using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TBQuestGame.Models
{
    public class Treasure : GameItem
    {

        public enum TreasureType
        {
            Necklace,
            Mirror,
            Whistle
        }

        public TreasureType Type { get; set; }

        public Treasure(int id, string name, int value, TreasureType type, string description, int experiencePoints)
            : base(id, name, value, description, experiencePoints)
        {
            Type = type;
        }

        public override string InformationString()
        {
            return $"{Name}: {Description}";
        }
    }
}