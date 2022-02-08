using System;
using System.Collections;

namespace Tutorial_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            //declare and initialize an array
            int[] schoolGrades = new int[5];

            schoolGrades[0] = 3;
            schoolGrades[1] = 2;
            schoolGrades[2] = 4;
            schoolGrades[3] = 1;
            schoolGrades[4] = 1;

            /*
            Console.WriteLine("Die Note bei Index 0 ist {0}", schoolGrades[2]);
            string userInput = Console.ReadLine();
            schoolGrades[2] = int.Parse(userInput);
            Console.WriteLine("Die Note bei Index 0 ist {0}", schoolGrades[2]);
            */

            //alternate way to create Array
            int[] schoolGradesMath = { 1, 3, 4, 5, 2, 3, 4, 5 };
            int[] schoolGradesGerman = new int[] { 1, 3, 4, 5, 2, 3, 4, 5 };
            Console.WriteLine("Length of Arry {0}", schoolGradesGerman.Length);

            //Foreach-Loop
            string[] freundesListe = { "Dani", "Marco", "Max", "Stefan", "Michael" };
            foreach (string name in freundesListe)
            {
                Console.WriteLine("Hallo {0}, was geht ab", name);
            }

            //Mehrdimensionale Arrays
            string[,] matrix;
            int[,,] threeD;

            int[,] array2D = new int[,]
            {
                {1,2,3},    //Zeile 0
                {4,5,6},    //Zeile 1
                {7,8,9},    //Zeile 2       
            };

            //array2D[Zeile,Spalte]
            Console.WriteLine("Wert an in arrray2D {0}", array2D[1, 1]);
            Console.WriteLine("Wert an in arrray2D {0}", array2D[1, 2]);
            Console.WriteLine("Wert an in arrray2D {0}", array2D[2, 0]);

            //declare of an 2D-Array with initialise
            string[,] array2DString = new string[3, 2]
            {
                {"eins", "zwei"},
                {"drei","vier"},
                {"fünf","sechs"},
            };

            Console.WriteLine("Wert in Postion 1:1 ist {0}", array2DString[1, 1]);
            array2DString[1, 1] = "Schnaps";
            Console.WriteLine("Wert in Postion 1:1 ist {0}", array2DString[1, 1]);
            Console.WriteLine("Dimensionen: {0}", array2DString.Rank);

            //verzweigte Arrays - jagged Arrays
            //declare of a jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[3];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 6, 7, 8, 9 };
            jaggedArray[2] = new int[] { 1, 2, 3 };
            Console.WriteLine("Wert {0}", jaggedArray[0][4]);

            //Array als Paramter einer Funktion
            int[] studentGrades = new int[] { 15, 14, 3, 18, 10, 11, 17 };
            Console.WriteLine("Der Durchschnitt ist {0}", GetAverage(studentGrades));

            //Arraylists kann mehrere Datentypen beinhalten
            //Declare Arraylists with undefined number of objects
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hallo");
            myArrayList.Add(3.1415);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(147);

            Console.WriteLine("Anzahl an Werten in Arraylist: {0}", myArrayList.Count);

            double sum = 0.0;
            foreach (object obj in myArrayList)
            {
                //Abfrage ob "obj" vom Datentyp "int" ist
                if (obj is int)
                {
                    //Wert des Obj in Double konvertieren
                    sum += Convert.ToDouble(obj);
                }else if (obj is double)
                {
                    sum += (double)obj;
                }else if(obj is string)
                {
                    Console.WriteLine("Obj ist {0}", obj);
                }
                Console.WriteLine(obj);
            }
            Console.WriteLine("Die Summe ist {0}", sum);

            //Löschen eines Eintrags mit spezifischen Inhalt
            myArrayList.Remove(13);
            //Löschen eines Eintrags bei spezifischen Index
            myArrayList.RemoveAt(0);
            Console.WriteLine("Anzahl an Werten in Arraylist: {0}", myArrayList.Count);


            Console.ReadKey();
        }

        public static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average = 0.0;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;

            return average;
        }
    }
}
