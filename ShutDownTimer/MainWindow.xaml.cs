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
using System.Windows.Threading;
using System.Diagnostics;

namespace ShutDownTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TimeSpan timeLeft;
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void timer_tick(object sender,EventArgs e)
        {
            //es muss die verbleibende Zeit reduziert werden
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            lblTimer.Content = timeLeft.ToString(@"hh\:mm\:ss");

            if (timeLeft.TotalSeconds <= 0)
            {
                timer.Stop();
                PeformAction();
            }
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            CheckTextBoxValues();
            bool isStartable = true;

            try
            {
                timeLeft = new TimeSpan(Convert.ToInt32(tbxHours.Text), Convert.ToInt32(tbxMinutes.Text), Convert.ToInt32(tbxSeconds.Text));
            }
            catch (FormatException ex)
            {
                isStartable = false;
                MessageBox.Show("Fehler bei Zeitangabe, bitte geben Sie Zahlen ein");
            }

            if (isStartable)
            {
                timer.Start();
                lblTimer.Content = timeLeft.ToString(@"hh\:mm\:ss");
            }

        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            lblTimer.Content = "00:00:00";
        }

        private void CheckTextBoxValues()
        {
            if (tbxHours.Text.Count() == 0)
            {
                tbxHours.Text = "00";
            }

            if (tbxMinutes.Text.Count() == 0)
            {
                tbxMinutes.Text = "00";
            }

            if (tbxSeconds.Text.Count() == 0)
            {
                tbxSeconds.Text = "00";
            }
        }

        private void PeformAction()
        {
            if (rbShutdownPC.IsChecked == true)
            {
                Process.Start("shutdown", "/s");
            }
            else if(rbRestartPC.IsChecked == true)
            {
                Process.Start("shutdown", "/r");
            }
            else if (rbSavePowerModusPC.IsChecked == true)
            {
                Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState");
            }
        }
    }
}
