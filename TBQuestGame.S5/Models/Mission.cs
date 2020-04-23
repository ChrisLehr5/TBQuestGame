using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Mission
    {
        public enum MissionStatus
        {
            Unassigned,
            Incomplete,
            Complete
        }

        private int _id;
        private string _name;
        private string _description;
        private MissionStatus _status;
        private string _statusDetail;
        private int _experiencePoints;
        private int _lives;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public MissionStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string StatusDetail
        {
            get { return _statusDetail; }
            set { _statusDetail = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }
        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }

        }

        public Mission()
        {

        }

        public Mission(int id, string name, MissionStatus status)
        {
            _id = id;
            _name = name;
            _status = status;
        }
    }
}
