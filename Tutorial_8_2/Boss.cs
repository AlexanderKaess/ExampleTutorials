using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_8_2
{
    class Boss : Employee
    {
        //variables

        //properties
        protected string CompanyCar { get; set; }

        //default constructor
        public Boss()
        {
            FirstName = "Kein Name";
            LastName = "Kein Name";
            Salary = 0;
            CompanyCar = "Kein Auto";
        }

        //constructor
        public Boss(string firstName, string lastName, int salary, string companyCar)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        //methodes
        public void Lead()
        {
            Console.WriteLine("Der Boss {0} {1} führt", this.FirstName, this.LastName);
        }

    }
}
