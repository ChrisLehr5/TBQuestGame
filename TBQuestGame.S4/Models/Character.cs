using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Character : ObservableObject
    {
        #region ENUMERABLES

        public enum TraitType
        {
            Charisma,
            Strength,
            Perception
        }

        #endregion

        #region FIELDS

        protected int _id;
        protected string _name;
        protected int _locationId;
        protected int _level;
        protected TraitType _trait;

        #endregion

        #region PROPERTIES

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

        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public int Age
        {
            get { return _level; }
            set { _level = value; }
        }

        public TraitType Trait
        {
            get { return _trait; }
            set { _trait = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(int id, string name, TraitType trait)
        {
            _name = name;
            _trait = trait;
            //_locationId = locationId;
        }

        protected Random random = new Random();

        #endregion

        #region METHODS

        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {_name} and I excel at {_trait}.";
        }

        #endregion
    }
}
