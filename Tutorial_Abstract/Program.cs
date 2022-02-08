using System;

namespace Tutorial_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            Elektriker hendrick = new Elektriker();
            hendrick.ArbeitVerrichten();
            hendrick.Gehalt = 2500;

            Handwerker horst = new Handwerker();
            horst.ArbeitVerrichten();
            horst.Gehalt = 6000;

            Mechatroniker michi = new Mechatroniker();
            michi.ArbeitVerrichten();
            michi.MehrArbeitVerrichten();

            Console.ReadKey();
        }
    }
}
