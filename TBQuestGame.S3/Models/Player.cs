using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;


namespace TBQuestGame.Models
{
    public class Player : Character
    {
        #region ENUMS

        public enum PlayThroughDifficulty { Casual, Normal, Difficult }

        #endregion

        #region FIELDS

        private int _lives;
        private int _health;
        private int _experiencePoints;
        private int _wealth;
        private PlayThroughDifficulty _playStyle;
        private List<Location> _locationsVisited;
        private ObservableCollection<GameItem> _inventory;
        private ObservableCollection<GameItem> _potions;
        private ObservableCollection<GameItem> _treasure;
        private ObservableCollection<GameItem> _keys;

        #endregion

        #region PROPERTIES

        public int Lives
        {
            get { return _lives; }
            set
            {
                _lives = value;
                OnPropertyChanged(nameof(Lives));
            }
        }

        public PlayThroughDifficulty PlayStyle
        {
            get { return _playStyle; }
            set
            {
                _playStyle = value;
                OnPropertyChanged(nameof(PlayStyle));
            }
        }

        public int Health
        {
            get { return _health; }
            set
            {
                _health = value;

                if (_health > 100)
                {
                    _health = 100;
                }
                else if (_health <= 0)
                {
                    _health = 100;
                    _lives--;
                }

                OnPropertyChanged(nameof(Health));
            }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }

        public int Wealth
        {
            get { return _wealth; }
            set
            {
                _wealth = value;
                OnPropertyChanged(nameof(Wealth));
            }
        }

        public List<Location> LocationsVisited
        {
            get { return _locationsVisited; }
            set { _locationsVisited = value; }
        }

        public ObservableCollection<GameItem> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        public ObservableCollection<GameItem> Potions
        {
            get { return _potions; }
            set { _potions = value; }
        }

        public ObservableCollection<GameItem> Treasure
        {
            get { return _treasure; }
            set { _treasure = value; }
        }

        public ObservableCollection<GameItem> Keys
        {
            get { return _keys; }
            set { _keys = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Player()
        {
            _locationsVisited = new List<Location>();
            _treasure = new ObservableCollection<GameItem>();
            _potions = new ObservableCollection<GameItem>();
            _keys = new ObservableCollection<GameItem>();
        }

        #endregion

        #region METHODS

        // set the players wealth based on the initial inventory
        //
        public void CalculateWealth()
        {
            Wealth = _inventory.Sum(i => i.Value);
        }

        //update the game item list

        public void UpdateInventoryCategories()
        {
            Potions.Clear();
            Treasure.Clear();
            Keys.Clear();

            foreach (var gameItem in _inventory)
            {
                if (gameItem is Potion) Potions.Add(gameItem);
                if (gameItem is Treasure) Treasure.Add(gameItem);
                if (gameItem is Key) Keys.Add(gameItem);
            }
        }

        /// <summary>
        /// remove selected item from inventory
        /// </summary>
        /// <param name="selectedGameItem">selected item</param>
        public void AddGameItemToInventory(GameItem selectedGameItem)
        {
            if (selectedGameItem != null)
            {
                _inventory.Add(selectedGameItem);
            }
        }

        /// <summary>
        /// remove selected item from inventory
        /// </summary>
        /// <param name="selectedGameItem">selected item</param>
        public void RemoveGameItemFromInventory(GameItem selectedGameItem)
        {
            if (selectedGameItem != null)
            {
                _inventory.Remove(selectedGameItem);
            }
        }



        //check to see if visited
        public bool HasVisited(Location location)
        {
            return _locationsVisited.Contains(location);
        }

        /// <summary>
        /// override the default greeting in the Character class to include the job title
        /// set the proper article based on the job title
        /// </summary>
        /// <returns>default greeting</returns>
        public override string DefaultGreeting()
        {
            string article = "a";

            List<string> vowels = new List<string>() { "A", "E", "I", "O", "U" };

            if (vowels.Contains(_playStyle.ToString().Substring(0, 1))) ;
            {
                article = "an";
            }

            return $"Hello, my name is {_name} and I am {article} {_playStyle} for the Aion Project.";
        }

        #endregion

        #region EVENTS



        #endregion

    }
}