using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class MissionEngage : Mission
    {
        private int _id;
        private string _name;
        private string _description;
        private MissionStatus _status;
        private string _statusDetail;
        private int _experiencePoints;
        private List<Npc> _requiredNpcs;

        public List<Npc> RequiredNpcs
        {
            get { return _requiredNpcs; }
            set { _requiredNpcs = value; }
        }

        public MissionEngage()
        {

        }

        public MissionEngage(int id, string name, MissionStatus status, List<Npc> requiredNpcs)
            : base(id, name, status)
        {
            _id = id;
            _name = name;
            _status = status;
            _requiredNpcs = requiredNpcs;
        }

        public List<Npc> NpcsNotCompleted(List<Npc> NpcsEngaged)
        {
            List<Npc> npcsToComplete = new List<Npc>();

            foreach (var requiredNpc in _requiredNpcs)
            {
                if (!NpcsEngaged.Any(l => l.Id == requiredNpc.Id))
                {
                    npcsToComplete.Add(requiredNpc);
                }
            }

            return npcsToComplete;
        }
    }
}

