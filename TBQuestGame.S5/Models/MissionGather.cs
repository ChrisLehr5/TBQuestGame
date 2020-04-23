using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class MissionGather : Mission
    {
        private int _id;
        private string _name;
        private string _description;
        private MissionStatus _status;
        private string _statusDetail;
        private int _experiencePoints;
        private List<GameItemQuantity> _requiredGameItemQuantities;

        public List<GameItemQuantity> RequiredGameItemQuantities
        {
            get { return _requiredGameItemQuantities; }
            set { _requiredGameItemQuantities = value; }
        }


        public MissionGather()
        {

        }

        public MissionGather(int id, string name, MissionStatus status, List<GameItemQuantity> requiredGameItemQuantities)
            : base(id, name, status)
        {
            _id = id;
            _name = name;
            _status = status;
            _requiredGameItemQuantities = requiredGameItemQuantities;
        }

        public List<GameItemQuantity> GameItemQuantitiesNotCompleted(List<GameItemQuantity> inventory)
        {
            List<GameItemQuantity> gameItemQuantitiesToComplete = new List<GameItemQuantity>();

            foreach (var missionGameItem in _requiredGameItemQuantities)
            {
                GameItemQuantity inventoryItemMatch = inventory.FirstOrDefault(gi => gi.GameItem.Id == missionGameItem.GameItem.Id);
                if (inventoryItemMatch == null)
                {
                    gameItemQuantitiesToComplete.Add(missionGameItem);
                }
                else
                {
                    if (inventoryItemMatch.Quantity < missionGameItem.Quantity)
                    {
                        gameItemQuantitiesToComplete.Add(missionGameItem);
                    }
                }
            }

            return gameItemQuantitiesToComplete;
        }
    }
}
