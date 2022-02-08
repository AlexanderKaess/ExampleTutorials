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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tutorial_11_GUI_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "VFB Stuttgart", Team2 = "FC Bayern", Score1 = 3, Score2 = 1, Completion = 85 });
            matches.Add(new Match() { Team1 = "Dortmund", Team2 = "FC Schalke", Score1 = 3, Score2 = 0, Completion = 35 });
            matches.Add(new Match() { Team1 = "Mainz", Team2 = "Hamburg", Score1 = 4, Score2 = 3, Completion = 3 });
            matches.Add(new Match() { Team1 = "Freiburg", Team2 = "Berlin", Score1 = 3, Score2 = 3, Completion = 60 });
            matches.Add(new Match() { Team1 = "Karlsruhe", Team2 = "Leverkusen", Score1 = 3, Score2 = 3, Completion = 10 });

            //Quelle (Liste matches) für die Daten setzen der ListBox
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Ausgewähltes Spiel: " + (lbMatches.SelectedItem as Match).Team1 + " gegen "
                + (lbMatches.SelectedItem as Match).Team2 + " Spielstand: " +
                (lbMatches.SelectedItem as Match).Score1 + " - " + (lbMatches.SelectedItem as Match).Score2);
            }
        }
    }
}
