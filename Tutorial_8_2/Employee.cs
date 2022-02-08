using System;

namespace Tutorial_8_2
{
    class Employee
    {
        //variables

        //properties
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Salary { get; set; }

        //default constructor
        public Employee()
        {
            FirstName = "Kein Name";
            LastName = "Kein Name";
            Salary = 0;
        }

        //constructor
        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        //methods
        //virtuelle Methoden können von erbenden Klassen überschrieben werden
        public virtual void Work()
        {
            Console.WriteLine("Methode Work() erledigt nichts");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Methode Pause() erledigt nichts");
        }
    }
}
