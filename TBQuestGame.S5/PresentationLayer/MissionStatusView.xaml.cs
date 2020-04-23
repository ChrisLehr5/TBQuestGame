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

namespace TBQuestGame.PresentationLayer
{
    /// <summary>
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class MissionStatusView : Window
    {
        MissionStatusViewModel _missionStatusViewModel;

        public MissionStatusView(MissionStatusViewModel missionStatusViewModel)
        {
            _missionStatusViewModel = missionStatusViewModel;
            DataContext = missionStatusViewModel;

            InitializeWindowTheme();

            InitializeComponent();
        }

        private void InitializeWindowTheme()
        {
            this.Title = "RocketCat Productions";
        }

        private void MissionStatusWindowClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
