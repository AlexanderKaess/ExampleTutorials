using System;
using System.IO;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            //on console appears: WBAKAESS
            Console.WriteLine(Environment.ExpandEnvironmentVariables("%USERNAME%"));
            Console.WriteLine("");

            //on console appears: C:\users\WBAKAESS
            Console.WriteLine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"));
            Console.WriteLine("");

            //on console appears: d:\archives\2001\media\images
            string[] paths = { @"d:\archives", "2001", "media", "images" };
            string fullPath = Path.Combine(paths);
            Console.WriteLine(fullPath);
            Console.WriteLine("");

            //on console appears: C:\Users\WBAKAESS\HALLO
            string fullFilePath = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "HALLO");
            Console.WriteLine(fullFilePath);
            Console.WriteLine("");

            //on console appears: checking clog2: C:\Users\WBAKAESS\CMMOSLoggingPath\CMMOSMachineName\clog 
            string FilePath3 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "CMMOSLoggingPath", "CMMOSMachineName", "clog");
            Console.WriteLine("checking clog2: " + FilePath3);
            Console.WriteLine("");

            //on console appears: GetFolderPath: ProgramFiles
            Console.WriteLine("GetFolderPath: {0}", Environment.SpecialFolder.ProgramFiles);
            //on console appears: GetFolderPath: C:\Program Files
            Console.WriteLine("GetFolderPath: {0}", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            //on console appears: GetFolderPath: C:\Program Files (x86)
            Console.WriteLine("GetFolderPath: {0}", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine("");

            //on console appears: C:\Program Files (x86)
            //string programFilesFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            //Console.WriteLine(programFilesFolder);
            //Console.WriteLine("");

            //on console appears: C:\Users\WBAKAESS\source\repos\Directory\bin\Debug\netcoreapp3.1
            string IniPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(IniPath);
            Console.WriteLine("");

            //soucePath = C:\Users\Public\Documents\Zeiss\Tracker\Log
            string sourceDir = @"C:\Users\Public\Documents\Zeiss\Tracker\Log";
            Console.WriteLine(sourceDir);

            //ResultPath = C:\InventaD1PreSeries\InventaD1_123456
            string targetDir = @"C:\InventaD1PreSeries\InventaD1_123456\";
            Console.WriteLine(targetDir);

            //add the log subfolder ZeissTrackerLog
            targetDir += @"ZeissTrackerLog\";
            Console.WriteLine(targetDir);

            //create a new target folder. 
            //if the directory already exists, this method does not create a new directory.
            Console.WriteLine("create folder: " + targetDir);
            System.IO.Directory.CreateDirectory(targetDir);

            //to copy all the files in one directory to another directory
            //check if the folder exists
            if (System.IO.Directory.Exists(sourceDir))
            {
                //check if the folder exists
                Console.WriteLine("folder: " + sourceDir + " exists");
                if (System.IO.Directory.Exists(targetDir))
                {
                    Console.WriteLine("folder: " + targetDir + " exists");
                    string[] files = System.IO.Directory.GetFiles(sourceDir);

                    //copy the files and overwrite destination files if they already exist
                    foreach (string s in files)
                    {
                        //use static Path methods to extract only the file name from the path
                        string fileName = Path.GetFileName(s);
                        string destFile = Path.Combine(targetDir, fileName);
                        File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("target path does not exist!");
                }
            }
            else
            {
                Console.WriteLine("source path does not exist!");
            }

            // Keep console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
