using System;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            string factMessage = "Extension methods have all the capabilities of regular static methods.";

            // Write the string and include the quotation marks.
            Console.WriteLine($"\"{factMessage}\"");

            // Simple comparisons are always case sensitive!
            bool containsSearchResult = factMessage.Contains("extension");
            Console.WriteLine($"Starts with \"extension\"? {containsSearchResult}");

            // For user input and strings that will be displayed to the end user, 
            // use the StringComparison parameter on methods that have it to specify how to match strings.
            bool ignoreCaseSearchResult = factMessage.StartsWith("extension", System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Starts with \"extension\"? {ignoreCaseSearchResult} (ignoring case)");

            bool endsWithSearchResult = factMessage.EndsWith(".", System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Ends with '.'? {endsWithSearchResult}");

            Console.WriteLine("\n");

            string source = "sensdef.sdo.refVector = 0,-60,-165";
            // Remove a substring from the middle of the string.
            string toRemove = "sensdef.sdo.refVector = ";
            string result = string.Empty;
            int i = source.IndexOf(toRemove);
            if (i >= 0)
            {
                result = source.Remove(i, toRemove.Length);
            }
            Console.WriteLine(source);
            Console.WriteLine(result);
            */

            string inputSnNumber = "1a2A34Bb567cC89";
            
            Console.WriteLine("\n");

            CheckSerialNumberInput(inputSnNumber);

            Console.WriteLine("ENDE");

            static void CheckSerialNumberInput(string inputSnNumber)
            {
                string searchContent = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzÄÜÖäüößÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿžŸ";

                char[] snCharArray = inputSnNumber.ToCharArray();               //input from user
                char[] searchCharArray = searchContent.ToCharArray();           //search content 
                for (int i = 0; i < snCharArray.Length; i++)
                {
                    string text = snCharArray[i].ToString();
                    text = text.PadLeft(text.Length + 3, '*');
                    text = text.PadRight(text.Length + 3, '*');
                    Console.WriteLine(text);
                    for (int j = 0; j < searchCharArray.Length; j++)
                    {
                        if (snCharArray[i].ToString() == searchCharArray[j].ToString())
                        {
                            Console.WriteLine("Fehler ist aufgetreten, der Inhalt: {0} ist vorhanden", searchCharArray[j].ToString());
                        }
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.ReadKey();
        }
    }
}
