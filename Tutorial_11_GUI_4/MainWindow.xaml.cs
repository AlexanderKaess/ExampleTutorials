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

namespace Tutorial_11_GUI_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Quelle (typeof(Colors).GetProperties()) für die Daten setzen der ComboBox
            comboBoxColors.ItemsSource = typeof(Colors).GetProperties();

        }

        private void cbAllTopings_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllTopings.IsChecked==true);
            cbSalami.IsChecked = newVal;
            cbMozarella.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllTopings.IsChecked = null;
            if (cbSalami.IsChecked==true && cbMozarella.IsChecked==true && cbMushrooms.IsChecked==true)
            {
                cbAllTopings.IsChecked = true;
            }

            if (cbSalami.IsChecked == false && cbMozarella.IsChecked == false && cbMushrooms.IsChecked == false)
            {
                cbAllTopings.IsChecked = false;
            }
        }
    }
}
