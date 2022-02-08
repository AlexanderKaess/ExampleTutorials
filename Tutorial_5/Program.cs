using System;

namespace Tutorial_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");
            MyForLoop();
            Console.WriteLine("");

            MyDoWhileLoop();
            Console.WriteLine("");

            MyWhileLoop();
            Console.WriteLine("");

            Console.Read();
        }

        public static void MyForLoop()
        {
            for (int counter = 10; counter >= 0; counter--)
            {
                Console.WriteLine("Zaehlerwert: {0}", counter);
            }
        }

        public static void MyDoWhileLoop()
        {
            int counter = 0;
            do
            {
                Console.WriteLine("Zaehlerwert: {0}", counter);
                counter++;
            } while (counter<10);
        }

        public static void MyWhileLoop()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("Zaehlerwert: {0}", counter);
                counter++;
            }
        }
    }
}
