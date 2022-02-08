using System;
using System.Collections.Generic;

namespace Tutorial_10_2
{
    class Program
    {
        //delegaten erstellen - delegate datentyp namen
        public delegate int SomeMath(int i, int e);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");
            DoSomething();

            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            List<int> evenNumbers = myList.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            foreach (int even in evenNumbers)
            {
                Console.WriteLine("EvenNumber: {0}", even);
            }

            //lampda expression - Parameter => Ausdruck
            List<int> oddNumbers2 = myList.FindAll(i => i % 2 == 1);
            oddNumbers2.ForEach(i => Console.WriteLine("OddNumber: {0}", i));

            Console.ReadKey();
        }

        public static void DoSomething()
        {
            SomeMath math = new SomeMath(Add);
            Console.WriteLine("Math: {0}", math(4,5));
        }

        public static int Add (int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }
    }

    public class Number
    {
        public int N { get; set; }
    }
}
