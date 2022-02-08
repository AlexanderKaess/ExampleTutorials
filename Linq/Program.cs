using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Alex");
            Console.WriteLine("");

            //definition of array numbers
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //call function OddNumbers with parameters (numbers)
            OddNumbers(numbers);


            Console.ReadKey();
        }

        static void OddNumbers (int[] numbers)
        {
            Console.WriteLine("Ungerade Zahlen :");

            //enumeration (Aufzählung) named oddNumbers, which includes integers
            //filling of oddNumber with odd numbers (ungeraden Zahlen)
            //it will go through the arry numbers with number, every single number (number) is checked
            //if number module 2 is not 0 (odd), if YES, then use (select) number, if not then not
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            //typ of oddNumbers --> System.Linq.Enumerable+WhereArrayIterator`1[System.Int32]
            Console.WriteLine(oddNumbers);

            //show the array numbers
            Console.Write("Zahlenreihe:");
            foreach (var number in numbers)
            {
                Console.Write(" " + number);
            }

            //show the odd numbers
            Console.Write("\n" + "Ungerade Zahlen sind:");
            foreach (var odd in oddNumbers)
            {
                Console.Write(" " + odd);
            }

        }
    }
}
