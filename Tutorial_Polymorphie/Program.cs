using System;

namespace Tutorial_Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            Begrüssung("Alex");
            Begrüssung("Larry", 29);
            Begrüssung("Marco", 30, true);
            
            Console.ReadKey();
        }

        static void Begrüssung(string name)
        {
            Console.WriteLine("Hallo mein Name ist {0}", name);
        }

        static void Begrüssung(string name, int alter)
        {
            Console.WriteLine("Hallo mein Name ist {0} und ich bin {1} Jahre alt", name, alter);
        }

        static void Begrüssung(string name, int alter, bool verheiratet)
        {
            if (verheiratet)
            {
                Console.WriteLine("Hallo mein Name ist {0} und ich bin {1} Jahre alt und bin verheiratet", name, alter);
            }else
            {
                Console.WriteLine("Hallo mein Name ist {0} und ich bin {1} Jahre alt und bin single", name, alter);
            }
        }

    }
}
