using System;

namespace Tutorial_6
{
    //class HUMAN
    //a class is a blue print of an object/data typ
    class Human
    {
        //member variables
        string firstName;
        string lastName;
        string eyeColor;
        int age;

        //default constructor
        public Human()
        {
            firstName = "unknown";
            lastName = "unknown";
            age = 0;
            eyeColor = "blue";
            Console.WriteLine("Default object of HUMAN is created");
        }

        //parameterised constructor, is called when an object of this class is created
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            Console.WriteLine("Object of HUMAN is created");
        }

        //parameterised constructor, is called when an object of this class is created
        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
            Console.WriteLine("Object of HUMAN is created");
        }

        //member method
        public void IntroduceMyself() 
        {
            if (age == 1)
            {
                Console.WriteLine("Hy my name is {0} {1} i'm {2} year old and have {3} eyes", firstName, lastName, age, eyeColor);

            }
            else
            {
                Console.WriteLine("Hy my name is {0} {1} i'm {2} years old and have {3} eyes", firstName, lastName, age, eyeColor);
            }
        }
    }
}
