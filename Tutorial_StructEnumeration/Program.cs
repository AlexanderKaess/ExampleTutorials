using System;

namespace Tutorial_StructEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            //struct
            Buch buch1 = new Buch("Alexander Kaess's Leben", "Alexander Kaess", 100);
            Console.WriteLine(buch1.title);
            Console.WriteLine(buch1.autor);
            Console.WriteLine(buch1.seitenAnzahl);

            //enumerations
            Himmelsrichtung richtung = Himmelsrichtung.West;
            Console.WriteLine((int)richtung);

            WochenTag tag = WochenTag.Montag;
            Console.WriteLine("Es ist {0}", tag);

            Console.ReadKey();
        }
    }

    //struct
    struct Buch
    {
        //variables
        public string title;
        public string autor;
        public int seitenAnzahl;

        //constructor
        public Buch(string _title, string _autor, int _seitenAnzahl)
        {
            title = _title;
            autor = _autor;
            seitenAnzahl = _seitenAnzahl;
        }
    }

    //enumerations
    enum Himmelsrichtung
    {
        Nord = 0,
        Ost = 1,
        Süd = 2,
        West = 3
    }

    enum WochenTag
    {
        Montag = 1,
        Dienstag,
        Mittwoch,
        Donnerstag,
        Freitag,
        Samstag,
        Sonntag
    }
}
