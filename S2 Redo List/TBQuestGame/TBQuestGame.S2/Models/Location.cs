using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Location
    {
        #region ENUMS


        #endregion

        #region FIELDS

        private int _id; // must be a unique value for each object
        private string _name;
        private string _description;
        private bool _accessible;
        private int _requiredExperiencePoints;
        private int _modifyExperiencePoints;
        private int _modifyHealth;
        private int _modifyLives;
        private string _message;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Accessible
        {
            get { return _accessible; }
            set { _accessible = value; }
        }

        public int ModifiyExperiencePoints
        {
            get { return _modifyExperiencePoints; }
            set { _modifyExperiencePoints = value; }
        }

        public int RequiredExperiencePoints
        {
            get { return _requiredExperiencePoints; }
            set { _requiredExperiencePoints = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public int ModifyHealth
        {
            get { return _modifyHealth; }
            set { _modifyHealth = value; }
        }

        public int ModifyLives
        {
            get { return _modifyLives; }
            set { _modifyLives = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Location()
        {

        }

        #endregion

        #region METHODS

        public override string ToString()
        {
            return _name;
        }

        #endregion
    }
}