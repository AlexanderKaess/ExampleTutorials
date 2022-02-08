using System;
using System.IO;

namespace Tutorial_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            //Aus einer Datei lesen 
            string text = File.ReadAllText(@"C:\Users\WBAKAESS\source\repos\Tutorial_10\MyTextFile.txt");
            Console.WriteLine("Die Text-Datei hat Text: {0}", text);

            Console.WriteLine("");

            string[] textArray = File.ReadAllLines(@"C:\Users\WBAKAESS\source\repos\Tutorial_10\MyTextFile.txt");
            Console.WriteLine("Die Zeile hat Text: {0}", textArray[0]);
            foreach (string zeile in textArray)
            {
                //"\t"  ist ein Tab
                Console.WriteLine("\t" + zeile);
            }

            //In eine Datei schreiben
            string[] zeilen = { "250", "333", "Hallo ich bin keine Zahl" };
            File.WriteAllLines(@"C:\Users\WBAKAESS\source\repos\Tutorial_10\MyTextFile_neu.txt", zeilen);

            //UserInput Name von Datei
            Console.WriteLine("Wie soll die Datei heissen:");
            string userInputName = Console.ReadLine();
            Console.WriteLine("Name: "+ userInputName);

            string path = userInputName + ".txt";
            string combindedPath = Path.Combine(@"C:\Users\WBAKAESS\source\repos\Tutorial_10\", path);

            //UserInput Inhalt von Datei
            Console.WriteLine("Was soll in die Datei geschrieben:");
            string userInputInhalt = Console.ReadLine();
            Console.WriteLine("Inhalt: " + userInputInhalt);

            //Inhalt in Datei schreiben
            File.WriteAllText(combindedPath, userInputInhalt);

            Console.ReadKey();
        }
    }
}
