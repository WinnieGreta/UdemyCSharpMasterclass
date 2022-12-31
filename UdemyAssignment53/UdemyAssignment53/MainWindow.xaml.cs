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

namespace UdemyAssignment53
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
            matches.Add(new Match() { Team1 = "aaa", Score1 = 3, Team2 = "bbb", Score2 = 2, Completion = 87 });
            matches.Add(new Match() { Team1 = "ccc", Score1 = 1, Team2 = "ddd", Score2 = 0, Completion = 63 });
            matches.Add(new Match() { Team1 = "eee", Score1 = 2, Team2 = "fff", Score2 = 2, Completion = 35 });
            matches.Add(new Match() { Team1 = "ggg", Score1 = 5, Team2 = "hhh", Score2 = 5, Completion = 72 });

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected match: " + (lbMatches.SelectedItem as Match).Team1 + " "
                    + (lbMatches.SelectedItem as Match).Score1 + ":"
                    + (lbMatches.SelectedItem as Match).Score2 + " "
                    + (lbMatches.SelectedItem as Match).Team2);
            }
        }

        public class Match
        {
            public int Score1 { get; set; }
            public int Score2 { get; set; }
            public string Team1 { get; set; }
            public string Team2 { get; set; }
            public int Completion { get; set; }
        }
    }
}
