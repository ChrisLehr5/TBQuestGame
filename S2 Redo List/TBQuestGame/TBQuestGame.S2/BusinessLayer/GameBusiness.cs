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

namespace TBQuestGame.BusinessLayer
{
    class GameBusiness
    {
        bool _newPlayer = true;

        GameSessionViewModel _gameSessionViewModel;
        Player _player = new Player();
        Map _gameMap;
        Location _currentLocation;        
        PlayerSetupView _playerSetupView;
        List<string> _messages;



        public GameBusiness() 
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();
        }        

        //initalize data set

        private void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _messages = GameData.InitialMessages();
            _gameMap = GameData.GameMap();          
            
        }

        //create view model and data set 

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(
                _player,
                _gameMap
                );
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            _playerSetupView.Close();

        }

        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new PlayerSetupView(_player);
                _playerSetupView.ShowDialog();

                //setup the game based on player properties selected 

                _player.ExperiencePoints = 0;
                _player.Health = 100;
                _player.Lives = 3;
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }
       
    }
}
