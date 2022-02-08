using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Interfaces
{
    class Hund : ITier
    {
        //properties
        public int Alter { get ; set ; }
        public string Geschlecht { get ; set ; }

        //constructor
        public Hund(int alter, string geschlecht)
        {
            this.Alter = alter;
            this.Geschlecht = geschlecht;
        }

        //methodes
        public void Essen()
        {
            Console.WriteLine("Der Hund isst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt...");
        }

        public void Bellen()
        {
            Console.WriteLine("Der Hund bellt...");
        }
    }
}
