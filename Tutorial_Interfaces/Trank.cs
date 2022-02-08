using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Interfaces
{
    class Trank : IGegenstand
    {
        //properties
        public int Goldwert { get; set; }
        public string Name { get; set; }

        //constructor
        public Trank(int goldwert, string name)
        {
            this.Goldwert = goldwert;
            this.Name = name;
        }

        //methods
        public void Benutzen()
        {
            Console.WriteLine("Du trinkst den Trank!");
        }

        public void Verkaufen()
        {
            Console.WriteLine($"Gegenstand Verkauft für {Goldwert}!");
        }
    }
}
