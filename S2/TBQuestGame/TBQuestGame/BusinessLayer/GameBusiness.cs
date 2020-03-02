using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.PresentationLayer;
using TBQuestGame.DataLayer;
using TBQuestGame.Models;
using System.Collections.ObjectModel;

namespace TBQuestGame.BusinessLayer
{
    class GameBusiness
    {

        GameSessionViewModel _gameSessionViewModel;
        Player _player = new Player();
        List<string> _messages;
        bool _newPlayer = true;
        PlayerSetupView _playerSetupView;
     


        public GameBusiness() 
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();
        }        

        //initalize data set

        private void InitializeDataSet()
        {            
            _messages = GameData.InitialMessages();
            
        }

        //create view model and data set 

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(
                _player,
                GameData.InitialMessages()
                //GameData.GameMap(),
                //GameData.IntialGameMapLocation()
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
