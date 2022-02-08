using System;

namespace Tutorial_3_4
{
    class Program
    {
        //Startpunkt des Progammes
        static void Main(string[] args)
        {
            //static = man benötigt kein Object dieser Methode um die Methode aufzurufen
            Console.WriteLine("Hello World, Kaess is the best!");
            //<Zugriffsmodifizierer><Rückgabetyp><Methodenname>(Parameterliste)
            //{
            //    Methodenkörper
            //}

            WriteSomething();
            WriteSomething();
            WriteSomething();
            Console.WriteLine("");

            string myArgument = "Hello i am text";
            WriteSomthingSpecific(myArgument);
            Console.WriteLine("");

            Console.WriteLine(Add(15, 23));
            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Divide(21,2));
            Console.WriteLine("");

            //Console.WriteLine(Calculate());

            Console.WriteLine("What is the current temperature: ");
            string userInput = Console.ReadLine();
            //int temperature = int.Parse(userInput);
            int temperature = 0;
            int outTemperatur = 0;

            if (int.TryParse(userInput, out outTemperatur))
            {
                temperature = outTemperatur;
            }
            else
            {
                temperature = 0;
            }

            if (temperature <= 20)
            {
                Console.WriteLine("its cold!");
            }
            else
            {
                Console.WriteLine("its warm!");
            }

            int alter = 19;

            switch (alter)
            {
                case 15:
                    Console.WriteLine("Du bist zu jung zum Feiern!");
                    break;
                case 25:
                    Console.WriteLine("Alles klar, ab gehts!");
                    break;

                default:
                    Console.WriteLine("Wie alt bist du eigentlich?");
                    break;
            }

            int temperature2 = -5;
            string stateOfMatter;

            if (temperature2 < 0)
            {
                stateOfMatter = "fest";
            }
            else if(temperature2 < 100 )
            {
                stateOfMatter = "flüssig";
            }
            else
            {
                stateOfMatter = "gas";
            }

            Console.WriteLine("Aggregatzustand: {0}", stateOfMatter);

            //Erweiterte If-Statement
            temperature2 += 30;
            //Bedingung ? wenn TRUE : wenn FALSE
            temperature2 += 100;
            stateOfMatter = temperature2 > 100 ? "gas" : (temperature2 < 0 ? "fest" : "flüssig") ;
            Console.WriteLine("Aggregatzustand: {0}", stateOfMatter);


            Console.ReadKey();
        }

        //Zugriffsmodifizierer (static) Rückgabetyp Methodenname (Parameter1, Parameter2,...){Methodenkörper}
        //Rückgabetyp void = leer, kein Rückgabetyp
        public static void WriteSomething()
        {
            Console.WriteLine("I am methode");
        }

        public static void WriteSomthingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        //Rückgabetyp int = Integer, Ganzzahl als Rückgabetyp
        public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //Rückgabetyp double = Fließkommazahl als Rückgabetyp
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static int Calculate()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Please insert first number:");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please inser second number:");
            string userInput2 = Console.ReadLine();

            try
            {
                num1 = int.Parse(userInput1);
                num2 = int.Parse(userInput2);

            }
            catch (FormatException)
            {
                Console.WriteLine("Failure, Format of the input is incorrect, please insert a number!");
         
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Failure, user input was empty, pleaser insert a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Failure, user input (number) was to long/big");
            }
            finally
            {
                Console.WriteLine("Please tap a key");
            }

            int result = num1 + num2;
            return result;
        }
    }
}
