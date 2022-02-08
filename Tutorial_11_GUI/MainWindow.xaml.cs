using System.Windows;
using System.Windows.Input;

namespace Tutorial_11_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent() er kümmert sich um Code der in MainWindow.xaml steht und führt ihn aus
            InitializeComponent();


        }

        //Sender = der Button in MainWindow.xaml
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Danke fürs klicken - Direkter Event","KaessMessageBox", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        //Schiebt das Event nach OBEN im Visual-Tree
        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Button wurde losgelassen - Bubbling Event", "KaessMessageBox", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        //Schiebt das Event nach UNTEN im Visual-Tree
        //Tunneling Events haben den Prefix "Preview"
        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Button wurde losgelassen - Tunneling Event", "KaessMessageBox", MessageBoxButton.OKCancel, MessageBoxImage.Information);

        }
    }
}
