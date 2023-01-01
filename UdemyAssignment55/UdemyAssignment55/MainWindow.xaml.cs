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

namespace UdemyAssignment55
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAllCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllTopings.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
            cbMozzarela.IsChecked = newVal;
        }

        private void cbSingleCheckedChanges(object sender, RoutedEventArgs e)
        {
            if((cbSalami.IsChecked == true) && (cbMushrooms.IsChecked == true) && (cbMozzarela.IsChecked == true))
            {
                cbAllTopings.IsChecked = true;
            }
            else if ((cbSalami.IsChecked == false) && (cbMushrooms.IsChecked == false) && (cbMozzarela.IsChecked == false))
            {
                cbAllTopings.IsChecked = false;
            }
            else
            {
                cbAllTopings.IsChecked = null;
            }
        }
    }
}
