using System;
using System.Collections.Generic;

namespace Tutorial_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            var autos = new List<Auto>
            {
                new Audi("A4", 200, "weis"),
                new Bmw("M3",400, "schwarz"),
            };

            foreach (var auto in autos)
            {
                auto.ReparaturAuto();
            }

            M3 myM3 = new M3("M33", 400, "gold");
            myM3.ReparaturAuto();

            Auto bmwZ3 = new Bmw("Z3", 400, "silber");
            bmwZ3.ZeigeDetails();
            bmwZ3.SetAutoIDInfo(123123, "Alex");
            bmwZ3.GetAutoIDInfo();

            Console.ReadKey();
        }
    }
}
