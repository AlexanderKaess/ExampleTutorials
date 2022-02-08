using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_6
{
    class Members
    {
        //member - private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public fields
        public int age;

        //member - properties - acces to jobTitle in a safe way
        public string JobTitle
        {
            get => jobTitle;
            set => jobTitle = value;
        }

        //public member Method - can be called from a other class
        public void Introducing (bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("HI, i am {0} and my job title is {1} and i am {2} years old", memberName, jobTitle, age);
            }
        }

        //private member Method - can not be called from other class
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //default constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 50000;
            jobTitle = "Entwickler";
            Console.WriteLine("Object of MEMBERS is created");
        }

        //member - finalizer - destructor
        //will be called when a object is killed
        //release of resourcen
        ~Members()
        {
            //Aufräumarbeiten
        }
    }
}
