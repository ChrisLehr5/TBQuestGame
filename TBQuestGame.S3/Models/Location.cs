using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TBQuestGame.Models
{
    public class Location : ObservableObject    {
        
            #region ENUMS


            #endregion

            #region FIELDS

            private int _id; // must be a unique value for each object
            private string _name;
            private string _description;
            private bool _accessible;
            private int _requiredExperiencePoints;
            private int _requiredKeyId;
            private int _modifiyExperiencePoints;
            private int _modifyHealth;
            private int _modifyLives;
            private string _message;
            private ObservableCollection<GameItem> _gameItems;

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
                get { return _modifiyExperiencePoints; }
                set { _modifiyExperiencePoints = value; }
            }

            public int RequiredExperiencePoints
            {
                get { return _requiredExperiencePoints; }
                set { _requiredExperiencePoints = value; }
            }

            public int RequiredKeyId
            {
                get { return _requiredKeyId; }
                set { _requiredKeyId = value; }
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

            public string Message
            {
                get { return _message; }
                set { _message = value; }
            }

        public ObservableCollection<GameItem> GameItems
        {
            get { return _gameItems; }
            set { _gameItems = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Location()
        {
            _gameItems = new ObservableCollection<GameItem>();
        }

        #endregion

        #region METHODS

        public void UpdateLocationGameItems()
        {
            ObservableCollection<GameItem> updatedLocationGameItems = new ObservableCollection<GameItem>();

            foreach (GameItem GameItem in _gameItems)
            {
                updatedLocationGameItems.Add(GameItem);
            }

            GameItems.Clear();

            foreach (GameItem gameItem in updatedLocationGameItems)
            {
                GameItems.Add(gameItem);
            }
        }

        /// <summary>
        /// add selected item to location
        /// </summary>
        /// <param name="selectedGameItem">selected item</param>
        public void AddGameItemToLocation(GameItem selectedGameItem)
        {
            if (selectedGameItem != null)
            {
                _gameItems.Add(selectedGameItem);
            }

            UpdateLocationGameItems();
        }

        /// <summary>
        /// remove selected item from location
        /// </summary>
        /// <param name="selectedGameItem">selected item</param>
        public void RemoveGameItemFromLocation(GameItem selectedGameItem)
        {
            if (selectedGameItem != null)
            {
                _gameItems.Remove(selectedGameItem);
            }

            UpdateLocationGameItems();
        }


        //
        // location is open if character has enough XP
        //
        public bool IsAccessibleByExperiencePoints(int playerExperiencePoints)
            {
                return playerExperiencePoints >= _requiredExperiencePoints ? true : false;
            }

            #endregion
        }
    }