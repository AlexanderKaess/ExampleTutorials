using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Interfaces
{
    class Schwert : IGegenstand
    {
        //properties
        public int Goldwert { get; set; }
        public string Name { get; set; }

        //constructor
        public Schwert(int goldwert, string name)
        {
            this.Goldwert = goldwert;
            this.Name = name;
        }

        //methods
        public void Benutzen()
        {
            Console.WriteLine("Du greifst an!");
        }

        public void Verkaufen()
        {
            Console.WriteLine($"Gegenstand Verkauft für {Goldwert}!");
        }
    }
}
