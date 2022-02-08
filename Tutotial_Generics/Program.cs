using System;

namespace Tutotial_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            //Generischer Typ
            WerteBehälter<int> myValue = new WerteBehälter<int>(1111);
            myValue.Ausgabe();
            WerteBehälter<string> myValue2 = new WerteBehälter<string>("hallo was geht ab");
            myValue2.Ausgabe();

            ObjectToText texter = new ObjectToText();
            int zahl = 234;
            texter.Ausgabe<int>(zahl);

            Console.ReadKey();
        }
    }

    //Generischer Typ
    public class WerteBehälter<T>
    {
        //variable
        private T meinWert;

        //constructor
        public WerteBehälter(T Wert)
        {
            meinWert = Wert;
        }

        //methods
        public void Ausgabe()
        {
            Console.WriteLine("Wert: {0}", meinWert.ToString());
        }
    }

    public class ObjectToText
    {
        //mehtods
        public void Ausgabe<T>(T myObject)
        {
            Console.WriteLine("Wert: {0}", myObject.ToString());
        }
    }
}
