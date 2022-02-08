using System;
using System.Collections.Generic;

namespace LampdaExpression
{
    delegate bool MyFunktion(int wert);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            var meineListe = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var meineGesiebteListe = MeineFunktion(affenWert => affenWert % 2 == 0, meineListe);

            foreach (var l in meineGesiebteListe)
            {
                Console.WriteLine(meineListe[l]);
            }


            Console.ReadKey();
        }

        public static List<int> MeineFunktion(MyFunktion eigenschaft, List<int> liste)
        {
            var sieb = new List<int>();
            sieb.Capacity = liste.Count;

            foreach (var li in liste)
            {
                if (eigenschaft(li))
                {
                    sieb.Add(li);
                }
            }

            return sieb;
        }

    }
}
