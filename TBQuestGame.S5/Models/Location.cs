using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace TBQuestGame.Models
{
    public class Location : ObservableObject
    {

        #region ENUMS


        #endregion

        #region FIELDS

        private int _id; // must be a unique value for each object
        private string _name;
        private string _description;
        private bool _accessible;
        private int _requiredExperiencePoints;
        private int _requiredKeyId;
        private int _requiredTreasureId;
        private int _modifiyExperiencePoints;
        private int _modifyHealth;
        private int _modifyLives;
        private string _message;
        //adding images
        private Image _imageOpenClose;
        private ObservableCollection<GameItemQuantity> _gameItems;
        private ObservableCollection<Npc> _npcs;

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

        public int RequiredTreasureId
        {
            get { return _requiredTreasureId; }
            set { _requiredTreasureId = value; }
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

        //adding images
        public Image ImageOpenClose
        {
            get { return _imageOpenClose; }
            set { _imageOpenClose = value; }
        }

        public ObservableCollection<GameItemQuantity> GameItems
        {
            get { return _gameItems; }
            set { _gameItems = value; }
        }

        public ObservableCollection<Npc> Npcs
        {
            get { return _npcs; }
            set { _npcs = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Location()
        {
            _gameItems = new ObservableCollection<GameItemQuantity>();
        }

        #endregion

        #region METHODS       

        public void UpdateLocationGameItems()
        {
            ObservableCollection<GameItemQuantity> updatedLocationGameItems = new ObservableCollection<GameItemQuantity>();

            foreach (GameItemQuantity GameItemQuantity in _gameItems)
            {
                updatedLocationGameItems.Add(GameItemQuantity);
            }

            GameItems.Clear();

            foreach (GameItemQuantity gameItemQuantity in updatedLocationGameItems)
            {
                GameItems.Add(gameItemQuantity);
            }
        }

        /// <summary>
        /// add selected item to location or update quantity if already in location
        /// </summary>
        /// <param name="selectedGameItemQuantity">selected item</param>
        public void AddGameItemQuantityToLocation(GameItemQuantity selectedGameItemQuantity)
        {
            //
            // locate selected item in location
            //
            GameItemQuantity gameItemQuantity = _gameItems.FirstOrDefault(i => i.GameItem.Id == selectedGameItemQuantity.GameItem.Id);

            if (gameItemQuantity == null)
            {
                GameItemQuantity newGameItemQuantity = new GameItemQuantity();
                newGameItemQuantity.GameItem = selectedGameItemQuantity.GameItem;
                newGameItemQuantity.Quantity = 1;

                _gameItems.Add(newGameItemQuantity);
            }
            else
            {
                gameItemQuantity.Quantity++;
            }

            UpdateLocationGameItems();
        }

        /// <summary>
        /// remove selected item from location or update quantity
        /// </summary>
        /// <param name="selectedGameItemQuantity">selected item</param>
        public void RemoveGameItemQuantityFromLocation(GameItemQuantity selectedGameItemQuantity)
        {
            //
            // locate selected item in location
            //
            GameItemQuantity gameItemQuantity = _gameItems.FirstOrDefault(i => i.GameItem.Id == selectedGameItemQuantity.GameItem.Id);

            if (gameItemQuantity != null)
            {
                if (selectedGameItemQuantity.Quantity == 1)
                {
                    _gameItems.Remove(gameItemQuantity);
                }
                else
                {
                    gameItemQuantity.Quantity--;
                }
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