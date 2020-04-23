using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;


namespace TBQuestGame.Models
{
    public class Player : Character, IBattle
    {
        #region ENUMS

        public enum PlayThroughDifficulty { Casual, Normal, Difficult }

        #endregion

        #region FIELDS

        private const int DEFENDER_DAMAGE_ADJUSTMENT = 10;
        private const int MAXIMUM_RETREAT_DAMAGE = 10;
        private int _lives;
        private int _health;
        private int _experiencePoints;
        private int _wealth;
        private int _skillLevel;
        private Weapon _currentWeapon;
        private BattleModeName _battleMode;
        private PlayThroughDifficulty _playStyle;
        private List<Location> _locationsVisited;
        private List<Npc> _npcsEngaged;

        private ObservableCollection<GameItemQuantity> _inventory;
        private ObservableCollection<GameItemQuantity> _potions;
        private ObservableCollection<GameItemQuantity> _treasure;
        private ObservableCollection<GameItemQuantity> _weapons;
        private ObservableCollection<GameItemQuantity> _keys;
        private ObservableCollection<Mission> _missions;


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

        public int SkillLevel
        {
            get { return _skillLevel; }
            set { _skillLevel = value; }
        }

        public Weapon CurrentWeapon
        {
            get { return _currentWeapon; }
            set { _currentWeapon = value; }
        }

        public BattleModeName BattleMode
        {
            get { return _battleMode; }
            set { _battleMode = value; }
        }

        public List<Location> LocationsVisited
        {
            get { return _locationsVisited; }
            set { _locationsVisited = value; }
        }

        public List<Npc> NpcsEngaged
        {
            get { return _npcsEngaged; }
            set { _npcsEngaged = value; }
        }

        public ObservableCollection<GameItemQuantity> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
        public ObservableCollection<GameItemQuantity> Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }

        public ObservableCollection<GameItemQuantity> Potions
        {
            get { return _potions; }
            set { _potions = value; }
        }

        public ObservableCollection<GameItemQuantity> Treasure
        {
            get { return _treasure; }
            set { _treasure = value; }
        }

        public ObservableCollection<GameItemQuantity> Keys
        {
            get { return _keys; }
            set { _keys = value; }
        }

        public ObservableCollection<Mission> Missions
        {
            get { return _missions; }
            set { _missions = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Player()
        {
            _locationsVisited = new List<Location>();
            _npcsEngaged = new List<Npc>();
            _treasure = new ObservableCollection<GameItemQuantity>();
            _potions = new ObservableCollection<GameItemQuantity>();
            _keys = new ObservableCollection<GameItemQuantity>();
            _weapons = new ObservableCollection<GameItemQuantity>();
            _missions = new ObservableCollection<Mission>();
        }

        #endregion

        #region METHODS

        public void UpdateMissionStatus()
        {
            //
            // Note: only loop through assigned missions and cast mission to proper child class
            //
            foreach (Mission mission in _missions.Where(m => m.Status == Mission.MissionStatus.Incomplete))
            {
                if (mission is MissionTravel)
                {
                    if (((MissionTravel)mission).LocationsNotCompleted(_locationsVisited).Count == 0)
                    {
                        mission.Status = Mission.MissionStatus.Complete;
                        ExperiencePoints += mission.ExperiencePoints;
                    }
                }
                else if (mission is MissionGather)
                {
                    if (((MissionGather)mission).GameItemQuantitiesNotCompleted(_inventory.ToList()).Count == 0)
                    {
                        mission.Status = Mission.MissionStatus.Complete;
                        ExperiencePoints += mission.ExperiencePoints;
                    }
                }
                else if (mission is MissionEngage)
                {
                    if (((MissionEngage)mission).NpcsNotCompleted(_npcsEngaged).Count == 0)
                    {
                        mission.Status = Mission.MissionStatus.Complete;
                        ExperiencePoints += mission.ExperiencePoints;
                    }
                }
                else
                {
                    throw new Exception("Unknown Mission child class.");
                }
            }
        }

        // set the players wealth based on the initial inventory
        //      

        public void CalculateWealth()
        {
            Wealth = _inventory.Sum(i => i.GameItem.Value * i.Quantity);
        }

        //update the game item list

        public void UpdateInventoryCategories()
        {
            Potions.Clear();
            Weapons.Clear();
            Treasure.Clear();
            Keys.Clear();

            foreach (var gameItemQuantity in _inventory)
            {
                if (gameItemQuantity.GameItem is Potion) Potions.Add(gameItemQuantity);
                if (gameItemQuantity.GameItem is Weapon) Weapons.Add(gameItemQuantity);
                if (gameItemQuantity.GameItem is Treasure) Treasure.Add(gameItemQuantity);
                if (gameItemQuantity.GameItem is Key) Keys.Add(gameItemQuantity);
            }
        }

        /// <summary>
        /// add selected item to inventory or update quantity if already in inventory
        /// </summary>
        /// <param name="selectedGameItemQuantity">selected item</param>
        public void AddGameItemQuantityToInventory(GameItemQuantity selectedGameItemQuantity)
        {
            //
            // locate selected item in inventory
            //
            GameItemQuantity gameItemQuantity = _inventory.FirstOrDefault(i => i.GameItem.Id == selectedGameItemQuantity.GameItem.Id);

            if (gameItemQuantity == null)
            {
                GameItemQuantity newGameItemQuantity = new GameItemQuantity();
                newGameItemQuantity.GameItem = selectedGameItemQuantity.GameItem;
                newGameItemQuantity.Quantity = 1;

                _inventory.Add(newGameItemQuantity);
            }
            else
            {
                gameItemQuantity.Quantity++;
            }

            UpdateInventoryCategories();
        }

        /// <param name="selectedGameItemQuantity">selected item</param>
        public void RemoveGameItemQuantityFromInventory(GameItemQuantity selectedGameItemQuantity)
        {
            //
            // locate selected item in inventory
            //
            GameItemQuantity gameItemQuantity = _inventory.FirstOrDefault(i => i.GameItem.Id == selectedGameItemQuantity.GameItem.Id);

            if (gameItemQuantity != null)
            {
                if (selectedGameItemQuantity.Quantity == 1)
                {
                    _inventory.Remove(gameItemQuantity);
                }
                else
                {
                    gameItemQuantity.Quantity--;
                }
            }

            UpdateInventoryCategories();
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

            return $"Hello, my name is {_name} and I am {article} {_playStyle}.";
        }

        #endregion


        #region BATTLE METHODS

        public int Attack()
        {
            int hitPoints = random.Next(CurrentWeapon.MinimumDamage, CurrentWeapon.MaximumDamage) * SkillLevel;

            if (hitPoints <= 100)
            {
                return hitPoints;
            }
            else
            {
                return 100;
            }
        }

        public int Defend()
        {
            int hitPoints = (random.Next(CurrentWeapon.MinimumDamage, CurrentWeapon.MaximumDamage) * SkillLevel) - DEFENDER_DAMAGE_ADJUSTMENT;

            if (hitPoints >= 0 && hitPoints <= 100)
            {
                return hitPoints;
            }
            else if (hitPoints > 100)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }

        public int Retreat()
        {
            int hitPoints = SkillLevel * MAXIMUM_RETREAT_DAMAGE;

            if (hitPoints <= 100)
            {
                return hitPoints;
            }
            else
            {
                return 100;
            }
        }




        #endregion

        #region EVENTS



        #endregion

    }
}