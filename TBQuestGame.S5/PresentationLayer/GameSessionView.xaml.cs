using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TBQuestGame.PresentationLayer
{
    /// <summary>
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class GameSessionView : Window
    {
        GameSessionViewModel _gameSessionViewModel;

        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;

            InitializeWindowTheme();
            InitializeComponent();

        }

        private void InitializeWindowTheme()
        {
            this.Title = "RocketCat Productions";
        }

        private void NorthTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveNorth();
        }

        private void EastTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveEast();
        }

        private void SouthTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveSouth();
        }

        private void WestTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveWest();
        }
        private void PickUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationItemsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.AddItemToInventory();
            }
        }

        private void PutDownButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerDataTabControl.SelectedItem != null)
            {
                _gameSessionViewModel.RemoveItemFromInventory();
            }
        }

        private void UseButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerDataTabControl.SelectedItem != null)
            {
                _gameSessionViewModel.OnUseGameItem();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string writerfile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WriteFile.txt");
            using (StreamWriter writer = new StreamWriter(writerfile))
            {
                writer.WriteLine(textBox1.Text);
                writer.WriteLine(textBox2.Text);
                writer.WriteLine(textBox3.Text);
                writer.WriteLine(textBox4.Text);
            }
            MessageBoxResult result = MessageBox.Show("The game has saved!");
        }

        private void SpeakToButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerTalkTo();
            }
        }

        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerAttack();
            }

        }

        private void DefendButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerDefend();
            }
        }

        private void RetreatButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerRetreat();
            }
        }


        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.QuiteApplication();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.HelpWindow();
        }

        private void InspectButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerDataTabControl.SelectedItem != null)
            {
                _gameSessionViewModel.InspectTheItem();
            }
        }

        private void MissionStatus_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.OpenMissionStatusView();
        }
    }
}