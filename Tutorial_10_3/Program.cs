using System;
using System.Collections;
using System.Collections.Generic;


namespace Tutorial_10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");
            //Array
            //Array ist unveränderbar, kann nicht erweitert (Länge, Anzahl) werden - immutable
            //jedes Element hat den gleichen Datentyp, limitiert auf einen Datentyp
            int[] scores = new int[] { 99, 90, 80, 50, 44, 33, 12 };

            //Lists
            //limitiert auf einen Datentyp
            //können erweitert (add) werden
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6 };
            myList.Add(32);
            myList.Add(12);
            myList.Add(22);
            myList.Add(123);
            //können sortiert werden
            myList.Sort();
            //an einer bestimmten Stelle löschen
            myList.RemoveAt(4);
            foreach (int l in myList)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("");
            //lampda-expression - parameter => ausdruck
            int index = myList.FindIndex(x => x == 22);
            Console.WriteLine(index);
            Console.WriteLine("");

            //ArrayLists
            //kann verschiedene Datentypen beinhalten
            ArrayList myArrayList = new ArrayList { 1, 2, 3, "hallo", true, false, "was ist hier los", 7, 99, 10 };
            foreach (var obj in myArrayList)
            {
                Console.WriteLine(obj);
            }


            Console.ReadKey();
        }
    }
}
