using System;
using System.Collections.Generic;
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
using TBQuestGame.Models;


namespace TBQuestGame.PresentationLayer
{
    /// <summary>
    /// Interaction logic for PlayerSetupView.xaml
    /// </summary>
    public partial class PlayerSetupView : Window
    {
        private Player _player;
        
        
        public PlayerSetupView(Player player)
        {
            _player = player;

            InitializeComponent();

            SetupWindow();
        }

        private void SetupWindow()
        {
            //generate content for inside the combo box 

            List<string> races = Enum.GetNames(typeof(Player.TraitType)).ToList();
            List<string> jobTitles = Enum.GetNames(typeof(Player.PlayThroughDifficulty)).ToList();
            JobTitleComboBox.ItemsSource = jobTitles;
            RaceComboBox.ItemsSource = races;

            //hide error message box
            ErrorMessageTextBlock.Visibility = Visibility.Hidden;
        }

        private bool IsValidInput(out string errorMessage)
        {
            errorMessage = "";

            if (NameTextBox.Text =="")
            {
                errorMessage += "Player Name is required.\n";
            }
            else
            {
                _player.Name = NameTextBox.Text;
            }
            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                errorMessage += "Player Age is required and must be a number.\n";
            }
            else
            {
                _player.Age = age;
            }

            return errorMessage == "" ? true : false;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage;

            if (IsValidInput(out errorMessage))
            {
                //get values from combo boxes 
                Enum.TryParse(JobTitleComboBox.SelectionBoxItem.ToString(), out Player.PlayThroughDifficulty playStyle);
                Enum.TryParse(RaceComboBox.SelectionBoxItem.ToString(), out Player.TraitType trait);

                //player properties 
                _player.PlayStyle = playStyle;
                _player.Trait = trait;

                Visibility = Visibility.Hidden;                    
            }
            else
            {
                //display error message 
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
                ErrorMessageTextBlock.Text = errorMessage;
            }
        }
    }
}
