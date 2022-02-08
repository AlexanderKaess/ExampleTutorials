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

namespace Tutorial_11_GUI_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbJa.IsChecked = true;
        }

        private void Ja_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Danke, dass du mich magst");
        }

        private void Nein_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Schade, dass du mich nicht magst");
        }

        private void Bild_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Schönes Bild");
        }
    }
}
