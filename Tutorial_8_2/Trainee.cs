using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_8_2
{
    class Trainee : Employee
    {
        //variables

        //properties
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        //default constructor
        public Trainee()
        {
            FirstName = "Kein Name";
            LastName = "Kein Name";
            Salary = 0;
            WorkingHours = 0;
            SchoolHours = 0;
        }

        //constructor
        //base nimmt die Properties von der Base-Klasse
        public Trainee(string firstName, string lastName, int salary, int workingHours, int schoolHour) : base(firstName, lastName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHour;
        }

        //methodes
        public void Learn()
        {
            Console.WriteLine("Der Trainee {0} {1} lernt {2} Stunden", this.FirstName, this.LastName, this.SchoolHours);
        }

        //virtuelle Methoden können von erbenden Klassen überschrieben werden
        //override überschreibt die virtuelle Methode
        public override void Work()
        {
            Console.WriteLine("Der Trainee {0} {1} arbeitet {2} Stunden", this.FirstName, this.LastName, this.WorkingHours);
        }
    }
}
