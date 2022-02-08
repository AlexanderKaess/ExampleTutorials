using System;

namespace Tutorial_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of class HUMAN
            Human h1 = new Human("Alexander", "Kaess", 30, "green");
            h1.IntroduceMyself();

            Human h2 = new Human("Larissa", "Vester", 29, "brown");
            h2.IntroduceMyself();

            Human unknown1 = new Human();
            unknown1.IntroduceMyself();

            Box b1 = new Box(2,2,2);
            b1.DisplayInfo();
            Console.WriteLine("The Frontside is: {0}", b1.FrontSide);

            Console.WriteLine("Hello World, Kaess is the best!");

            Console.ReadKey();
        }
    }
}
