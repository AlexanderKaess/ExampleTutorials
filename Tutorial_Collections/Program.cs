using System;
using System.Collections.Generic;

namespace Tutorial_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            //Lists = Liste
            CreateNameList();

            //Stacks = Stapel
            CreateStack();

            //Queues = Warteschlange
            CreateQueues();

            //Dictionary - Wörterbuch, KEY-Value Paare
            CreateDictionary();

            Console.ReadKey();
        }

        //Lists = Liste
        public static void CreateNameList()
        {
            //Create list
            List<int> zahlenListe = new List<int>();

            //add values to list
            zahlenListe.Add(1);
            zahlenListe.Add(2);
            zahlenListe.Add(3);
            zahlenListe.Add(4);
            zahlenListe.Add(5);

            //outout the list with for-loop
            for (int i = 0; i < zahlenListe.Count; i++)
            {
                Console.WriteLine("Zahl: {0}", zahlenListe[i]);
            }
            Console.WriteLine("----------------------");

            //remove values from list
            zahlenListe.Remove(4);
            zahlenListe.RemoveAt(0);

            //outout the list with foreach-loop
            foreach (int i in zahlenListe)
            {
                Console.WriteLine("Zahl: {0}", i);
            }
            Console.WriteLine("----------------------");

        }

        //Stacks = Stapel
        public static void CreateStack()
        {
            //create stack
            Stack<int> zahlenStapel = new Stack<int>();

            //add new values on top of the stack
            zahlenStapel.Push(1);
            zahlenStapel.Push(2);
            zahlenStapel.Push(3);

            //read values from stack
            Console.WriteLine(zahlenStapel.Pop());
            Console.WriteLine(zahlenStapel.Pop());
            Console.WriteLine(zahlenStapel.Peek());
            Console.WriteLine(zahlenStapel.Peek());
            Console.WriteLine("----------------------");
        }

        //Queues = Warteschlange
        public static void CreateQueues()
        {
            //create queue (Warteschlange)
            Queue<string> warteSchlange = new Queue<string>();

            //add value to queue
            warteSchlange.Enqueue("Alex");
            warteSchlange.Enqueue("Marco");
            warteSchlange.Enqueue("Daniel");
            warteSchlange.Enqueue("Larissa");

            //output the values of queue
            Console.WriteLine(warteSchlange.Dequeue());
            Console.WriteLine(warteSchlange.Dequeue());
            Console.WriteLine(warteSchlange.Dequeue());
            Console.WriteLine(warteSchlange.Peek());
            Console.WriteLine(warteSchlange.Peek());
            Console.WriteLine("----------------------");
        }

        //Dictionary - Wörterbuch, KEY-Value Paare
        public static void CreateDictionary()
        {
            //create dictionary
            Dictionary<string, int> wochenTage = new Dictionary<string, int>();

            //add value to dictionary
            wochenTage.Add("Montag",1);
            wochenTage.Add("Dienstag", 2);
            wochenTage.Add("Mittwoch", 3);
            wochenTage.Add("Donnerstag", 4);
            wochenTage.Add("Freitag", 5);
            wochenTage.Add("Samstag", 6);
            wochenTage.Add("Sonntag", 7);

            //output value of dictionary
            Console.WriteLine(wochenTage["Donnerstag"]);
        }
    }
}
