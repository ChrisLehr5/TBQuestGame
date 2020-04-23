using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TBQuestGame.Models
{
    public class Treasure : GameItem
    {

        public enum UseActionType
        {
            OPENLOCATION,
            KILLPLAYER
        }

        public UseActionType UseAction { get; set; }

        public Treasure(int id, string name, int value, string description, int experiencePoints, string useMessage, string inspect, UseActionType useAction)
             : base(id, name, value, description, experiencePoints, useMessage, inspect)
        {
            //Type = type;
            UseAction = useAction;
        }

        public override string InformationString()
        {
            return $"{Name}: {Description}";
        }
    }
}


