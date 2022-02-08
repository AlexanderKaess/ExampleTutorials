using System;

namespace Tutorial_Delegaten
{
    class Program
    {
        //1. Delegaten (Funktionszeiger) definieren
        delegate int Berechne(int x, int y);

        //Multicast delegaten definieren
        delegate void Ausgabe();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            //3. Delegaten erstellen und aufrufen 
            //rechnenAufrufer ist ein Funktionszeiger auf Funktion Addition
            //In Variable rechnenAufrufer steckt die Referenz auf Funktion Addition
            //man kann nun über die Variable rechnenAufrufer die Funktion Addition aufrufen
            Berechne rechnenAufrufer = new Berechne(Addition);
            int ergebnis = rechnenAufrufer(5, 3);
            Console.WriteLine("Ergebnis: {0}", ergebnis);

            //Multicast delegaten erstellen und aufrufen
            Ausgabe multiAufrufer = new Ausgabe(Begrussung);
            multiAufrufer();
            multiAufrufer += Smalltalk;
            multiAufrufer();
            multiAufrufer += Verabschiedung;
            multiAufrufer();

            Console.ReadKey();
        }

        //2. Funktionen definieren
        static int Addition(int x, int y)
        {
            return x + y;
        }

        static int Subtraktion(int x, int y)
        {
            return x - y;
        }

        //Funktionen für Multicast delegaten definieren
        static void Begrussung()
        {
            Console.WriteLine("Hallo");
        }

        static void Smalltalk()
        {
            Console.WriteLine("Das Wetter ist schlecht");
        }

        static void Verabschiedung()
        {
            Console.WriteLine("Tschaule");
        }
    }
}
