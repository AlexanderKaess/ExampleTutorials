using System;
using System.Globalization;

namespace Test_IFormatProviderCultureInfo
{
    //The following example illustrates how an IFormatProvider implementation can change 
    //the representation of a date and time value. In this case, a single date is displayed 
    //by using CultureInfo objects that represent four different cultures.
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            DateTime date1 = DateTime.Now;

            CultureInfo[] cultures = { new CultureInfo("us-US"),
                                 new CultureInfo("fr-FR"),
                                 new CultureInfo("it-IT"),
                                 new CultureInfo("de-DE") };

            foreach (CultureInfo culture in cultures)
            {
                Console.WriteLine("{0}: {1}", culture.Name, date1.ToString(culture));
            }

            Console.WriteLine(Convert.ToString(date1, CultureInfo.InvariantCulture));
            Console.WriteLine(date1);

            Console.ReadKey();
        }
    }
}
