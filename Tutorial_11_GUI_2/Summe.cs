using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tutorial_11_GUI_2
{
    public class Summe : INotifyPropertyChanged
    {
        //variables
        private string num1;
        private string num2;
        private string result;

        //Properties
        public string Num1
        {
            get { return num1; }
            //Wert von Num1 soll gesetzt werden, wenn OnPropertyChanged ausgeführt wird
            set
            {
                int number;
                //res ist "true" wenn value eine int ist
                bool res = int.TryParse(value, out number);
                if (res) num1 = value;
                //wenn der wert "num1" verändert wird soll auch der wert von porperty "Num1" geändert werden
                OnPropertyChanged("Num1");
                //OnPropertyChanged("Result") muss hier aufgerufen werden damit sich das Ergebnis direkt ändert
                OnPropertyChanged("Result");
            }
        }

        public string Num2
        {
            get { return num2; }
            //Wert von Num2 soll gesetzt werden, wenn OnPropertyChanged ausgeführt wird
            set
            {
                int number;
                //res ist "true" wenn value eine int ist
                bool res = int.TryParse(value, out number);
                if (res) num2 = value;
                //wenn der wert "num2" verändert wird soll auch der wert von porperty "Num2" geändert werden
                OnPropertyChanged("Num2");
                //OnPropertyChanged("Result") muss hier aufgerufen werden damit sich das Ergebnis direkt ändert
                OnPropertyChanged("Result");
            }
        }

        public string Result
        {
            get 
            { 
                //Num1 und Num2 wird nur zugewiesen wenn die Properties "parsebar" wwaren
                int res = int.Parse(Num1) + int.Parse(Num2);
                return res.ToString();
            }
            //Wert von Num1 soll gesetzt werden, wenn OnPropertyChanged ausgeführt wird
            set
            {
                //Num1 und Num2 wird nur zugewiesen wenn die Properties "parsebar" wwaren
                int res = int.Parse(Num1) + int.Parse(Num2);
                result = res.ToString();
                //wenn der wert "num1" verändert wird soll auch der wert von porperty "Num1" geändert werden
                OnPropertyChanged("Result");
            }
        }


        //Event wartet darauf dass sich eine Property ändert und dann wird es ausgeführt
        public event PropertyChangedEventHandler PropertyChanged;

        //Methode die das Event (property wurde geändert) das ausgeführt wurde verwendet
        private void OnPropertyChanged(string property)
        {
            //PropertyChanged nur ausführend wenn es nicht NULL ist
            if (PropertyChanged != null)
            {
                //this = Sender des Events
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }   
        }

    }
}
