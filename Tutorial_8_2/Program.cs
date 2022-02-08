using System;

namespace Tutorial_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            Employee employee1 = new Employee("Horst", "Müller", 50000);
            Boss boss1 = new Boss("Alexander","Kaess", 100000, "BMW 330d");
            Trainee trainee1 = new Trainee("Larissa", "Vester", 500, 20, 40);

            boss1.Lead();
            trainee1.Work();

            Console.ReadKey();
        }
    }
}
