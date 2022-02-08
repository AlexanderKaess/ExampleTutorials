using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Interfaces
{
    class Loewe : ITier
    {
        //properties
        public int Alter { get ; set; }
        public string Geschlecht { get; set ; }

        //constructor
        public Loewe(int alter, string geschlecht)
        {
            this.Alter = alter;
            this.Geschlecht = geschlecht;
        }

        //methods
        public void Essen()
        {
            Console.WriteLine("Der Loewe isst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Loewe trinkt...");
        }
    }
}
