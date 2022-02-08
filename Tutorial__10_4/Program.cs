using System;

namespace Tutorial__10_4
{
    class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
        enum Month { Januar = 1, Februar, März, April, Mai, Juni = 8, Juli , August, September, Oktober, November, Dezember};


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, C# is the best!");

            Game game1;
            game1.name = "pokemonGo";
            game1.developer = "Alex";
            game1.rating = 3.6;
            game1.releaseDate = "01.07.2016";
            game1.DisplayInfo();

            Day freitag = Day.Fr;
            Day montag = Day.Mo;
            Day a = Day.Fr;

            Console.WriteLine(freitag==a);
            Console.WriteLine((int)montag);

            Console.ReadKey();
        }

        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public void DisplayInfo()
            {
                Console.WriteLine("Spiel 1 wurden heisst {0}", name);
                Console.WriteLine("Spiel 1 wurden entwickelt von {0}", developer);
                Console.WriteLine("Spiel 1 hat rating von {0}", rating);
                Console.WriteLine("Spiel 1 wurden Herausgebracht {0}", releaseDate);
            }
        }
    }
}
