using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Key : GameItem
    {

        public enum UseActionType
        {
            OPENLOCATION,
            KILLPLAYER,
            PLAYERWIN
        }

        public UseActionType UseAction { get; set; }

        public Key(int id, string name, int value, string description, int experiencePoints, string useMessage, string inspect, UseActionType useAction)
            : base(id, name, value, description, experiencePoints, useMessage, inspect)
        {
            UseAction = useAction;
        }

        public override string InformationString()
        {
            return $"{Name}: {Description}";
        }
    }
}

