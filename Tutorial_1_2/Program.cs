using System;

namespace Tutorial_1_2
{
    class Program
    {
        //entry for the program
        static void Main(string[] args)
        {
            //###class console###
            Console.WriteLine("");
            //set the background color of the console
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //set the foreground/font color of the console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Beep();

            Console.WriteLine("Hello World, Kaess is the best!");
            Console.WriteLine("I am Alex");
            Console.WriteLine("Hello");

            //###datatyps and variables###
            //###string### 
            //declare and initialize
            string vorName = "Alexander";
            string nachName = "Kaess";
            string nachricht = "My name is: " + vorName + " " + nachName;
            int laengeNachricht = nachricht.Length;
            //nachricht with capitalized letters
            string nachrichtInGroß = nachricht.ToUpper();
            //nachricht with lower case letters
            string nachrichtInKlein = nachricht.ToLower();
            Console.WriteLine(nachricht + " und die Nachricht ist {0} Zeichen lang", laengeNachricht);
            Console.WriteLine("My name is: {0} {1}", vorName, nachName);
            Console.WriteLine(nachrichtInGroß);
            Console.WriteLine(nachrichtInKlein);
            Console.WriteLine("");

            //###integer, floar and double###
            //declare and initialize of variable age
            int age1 = 30;
            //deklarieren
            int age2;
            //initialisieren
            age2 = 3;
            int summeAge = age1 + age2;
            Console.WriteLine("Totalage: {0}", summeAge);

            //usage of double
            double d1 = 333;
            double d2 = 1.3;
            double doubleResult = d1 / d2;
            Console.WriteLine("Double result: {0}", doubleResult);

            //usage of float
            float f1 = 1.337f;
            Console.WriteLine("Float value: {0}", f1);
            Console.WriteLine("");

            //###name conventions and coding standards###
            Console.WriteLine("Class names and Methods in camelCase and captialized: MyClassName, MyMethodName");
            Console.WriteLine("Arguments in camelCase and lower case: myArgument");
            Console.WriteLine("Variable names: myVariableName");
            Console.WriteLine("Boolean names: isSaved, isCool");
            Console.WriteLine("");

            //implicit conversion 
            int num = 123456;
            long bigNum = num;
            Console.WriteLine("num: {0}", bigNum);

            float myFloat = 13.33f;
            double myDouble = myFloat;
            Console.WriteLine("myDouble: {0}", myDouble);

            //explicit conversion
            int myInt;
            double mynewDouble = 13.44566554;
            myInt = (int)mynewDouble;
            Console.WriteLine("myInt: {0}", myInt);

            string myString = myDouble.ToString();
            Console.WriteLine("myString: {0}", mynewDouble);

            //parsing a string to a integer
            //parsing makes a value in a string to an integer
            string myString1 = "15";
            string myString2 = "12";

            int num1 = int.Parse(myString1);
            int num2 = int.Parse(myString2);

            int resultInt = num1 + num2;
            Console.WriteLine("The resultInt is: {0}", resultInt);
            Console.WriteLine("");

            const double PI = 3.1415;
            const int weeksPerYear = 52;
            const int monthsPerYear = 12;
            Console.WriteLine("A Year have {0} weeks and {1} months", weeksPerYear, monthsPerYear);

            Console.ReadKey();
        }
    }
}
