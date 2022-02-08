using System;

namespace Tutorial_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            ITier[] tierSammlung = new ITier[3];
            tierSammlung[0] = new Loewe(10, "weibchen");
            tierSammlung[1] = new Hund(4, "männchen");
            tierSammlung[2] = new Hund(8, "weibchen");

            foreach (ITier tier in tierSammlung)
            {
                if (tier is Loewe)
                {
                    Console.WriteLine("Der Löwe ist {0} und ein {1}", tier.Alter, tier.Geschlecht);
                }
                else if (tier is Hund)
                {
                    Console.WriteLine("Der Hund ist {0} und ein {1}", tier.Alter, tier.Geschlecht);
                }
            }

            IGegenstand[] gegenstandSammlung = new IGegenstand[3];
            gegenstandSammlung[0] = new Schwert(10, "Laserschwert");
            gegenstandSammlung[1] = new Schwert(15, "Samuraischwert");
            gegenstandSammlung[2] = new Trank(20, "VodkaBull");

            foreach (IGegenstand gegenstand in gegenstandSammlung)
            {
                if (gegenstand is Schwert)
                {
                    Console.WriteLine("Das Schwert kostet {0} und ist ein {1}", gegenstand.Goldwert, gegenstand.Name);
                }
                else if (gegenstand is Trank)
                {
                    Console.WriteLine("Der Trank kostet {0} und ist ein {1}", gegenstand.Goldwert, gegenstand.Name);
                }
            }


            Console.ReadKey();
        }
    }
}
