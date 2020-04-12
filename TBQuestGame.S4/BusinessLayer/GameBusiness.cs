using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.PresentationLayer;
using TBQuestGame.DataLayer;
using TBQuestGame.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Media;

namespace TBQuestGame.BusinessLayer
{
    //
    // true: open player setup window - uncomment the Close() method in InstantiateAndShowView
    // false: player data coming from GameData class
    //

    public class GameBusiness
    {
        bool _newPlayer = true;

        GameSessionViewModel _gameSessionViewModel;
        Player _player = new Player();
        Map _gameMap;
        GameMapCoordinates _initialLocationCoordinates;

        PlayerSetupView _playerSetupView = null;

        public GameBusiness()
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();

            SoundPlayer player = new SoundPlayer(@"C:\Users\Khyr\Documents\Downloads\music.wav");
            player.Load();
            player.PlayLooping();
        }

        /// <summary>
        /// setup new or existing player
        /// </summary>
        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new PlayerSetupView(_player);
                _playerSetupView.ShowDialog();

                _player.ExperiencePoints = 0;
                _player.Health = 100;
                _player.Lives = 3;
                _player.SkillLevel = 5;


            }
            else
            {
                _player = GameData.PlayerData();
            }
        }

        /// <summary>
        /// initialize data set
        /// </summary>
        private void InitializeDataSet()
        {
            _gameMap = GameData.GameMap();
            _initialLocationCoordinates = GameData.InitialGameMapLocation();

        }

        /// <summary>
        /// create view model with data set
        /// </summary>
        private void InstantiateAndShowView()
        {
            //
            // instantiate the view model and initialize the data set
            //
            _gameSessionViewModel = new GameSessionViewModel(
                _player,
                _gameMap,
                _initialLocationCoordinates
                );
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();


            // dialog window is initially hidden to mitigate issue with
            // main window closing after dialog window closes

            _playerSetupView.Close();
        }
    }
}