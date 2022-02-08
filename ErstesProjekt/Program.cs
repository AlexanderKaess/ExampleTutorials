using System;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace ErstesProjekt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Alex");
            Console.WriteLine("");

            Console.WriteLine(Environment.ExpandEnvironmentVariables("%USERNAME%"));
            Console.WriteLine(Environment.ExpandEnvironmentVariables( "%USERPROFILE%"));
            Console.WriteLine("");

            /*
            string[] paths = { @"d:\archives", "2001", "media", "images" };
            string fullPath = Path.Combine(paths);
            Console.WriteLine(fullPath);
            Console.WriteLine("");

            string FilePath = Environment.ExpandEnvironmentVariables("%USERPROFILE%");
            string fullFilePath = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "HALLO");
            Console.WriteLine(fullFilePath);
            Console.WriteLine("");

            string FilePath3 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "CMMOSLoggingPath", "CMMOSMachineName", "clog");
            Console.WriteLine("checking clog2: " + FilePath3);
            Console.WriteLine("");

            string DMELogFilePath1 = Environment.ExpandEnvironmentVariables("%USERPROFILE%");
            Console.WriteLine(DMELogFilePath1);
            Console.WriteLine("");

            Console.WriteLine("GetFolderPath: {0}", Environment.SpecialFolder.ProgramFiles);
            Console.WriteLine("GetFolderPath: {0}", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));

            Console.WriteLine("GetFolderPath: {0}", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine("");

            string programFilesFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            Console.WriteLine(programFilesFolder);
            Console.WriteLine("");

            string IniPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(IniPath);
            Console.WriteLine("");

            Console.WriteLine("###################################################");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(10000);
            stopWatch.Stop();
            // Get the elapsed time (Ablaufzeit) as a TimeSpan (Zeitspanne) value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("");

            Console.WriteLine("##################################################");
            Console.WriteLine("Whats your name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Your name is: " + username);

            Console.WriteLine("##################################################");
            //Get Actual Time
            DateTime timespan = DateTime.Now;
            double hourstomin = timespan.Hour;
            hourstomin = hourstomin * 60;
            double mintomin = timespan.Minute;
            double Passedmins = hourstomin + mintomin;
            Console.WriteLine("Passed time: " + Passedmins);
            */

            Console.WriteLine("##################################################");
            // Start Google Chrome Defaults to the home page.
            Console.WriteLine("Starts google chrome! ");
            //Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");


            Console.WriteLine("Hallo hier kommt ein Tab:\t hier ");
            Console.WriteLine("Hallo hier kommt ein Alert:\a hier ");

            Console.ReadKey();
        }
    }
}