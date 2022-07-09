using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public abstract class Npc : Character
    {

        public string Description { get; set; }
        public string Information
        {
            get
            {
                return InformationText();
            }
            set
            {

            }
        }

        public Npc()
        {

        }

        public Npc(int id, string name, TraitType trait, SkillLevel skill, string description)
            : base(id, name, trait, skill)
        {
            Id = id;
            Name = name;
            Trait = trait;
            Skill = skill;
            Description = description;
        }

        protected abstract string InformationText();
    }
}
