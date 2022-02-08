using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Abstract
{
    //abstracte Basisklasse, die nicht instanziiert werden kann
    //es kann keine Objekt von dieser Klasse erstellt werden
    abstract class Arbeiter
    {
        //properties
        public string Name { get; set; }
        public double Gehalt { get; set; }

        //methods
        //abstract - nur die Signatur einer Methode, 
        //darf keinen Inhalt (Methodenkörper) haben, darf nicht codiert werden
        public abstract void ArbeitVerrichten();

        //virtual - Standardfall einer Methode, braucht einen Methodenkörper
        //Methode kann in abgeleite Klassen überschrieben werden
        public virtual void MehrArbeitVerrichten()
        {
            Console.WriteLine("Noch mehr Arbeit muss verrichtet werden...");
        }

    }
}
