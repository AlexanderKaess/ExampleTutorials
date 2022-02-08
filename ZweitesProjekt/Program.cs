using System;
using Microsoft.Win32;
using System.Diagnostics;

namespace ZweitesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Create a Subkey
            RegistryKey rk1 = Registry.LocalMachine;

            // Print out the keys.
            Console.WriteLine("\n");
            Console.WriteLine(rk1);
            PrintKeys(rk1);

            Console.WriteLine("\n");

            //the name of the key must include a valid root.
            string localMachineRoot = rk1.Name;
            string subKey = "SOFTWARE";
            string subKey1 = "Zeiss";
            string subKey2 = "CMMOS-NEO";
            string subKey3 = "1.02"; 
            string valueName= "PathX64";

            string keyName = localMachineRoot + @"\" + subKey + @"\" + subKey1 + @"\" + subKey2 + @"\" + subKey3;

            //your default value is returned if the name/value pair does not exist.
            string valuePathX64 = Convert.ToString(Registry.GetValue(keyName, valueName, ""));
            Console.WriteLine("\nValue of keyName --{0}-- is {1}", keyName, valuePathX64);
            Console.WriteLine("\n");
            Console.WriteLine("keyName is " + keyName);

            string progName = "CMMOS_NEO.exe";
            string progPath = valuePathX64 + progName;
            Console.WriteLine(progPath);

            //starting application CMMOS_NEO.exe
            //Process prog = new Process();
            //prog.StartInfo.FileName = progPath;
            //prog.StartInfo.RedirectStandardInput = true;
            //prog.StartInfo.RedirectStandardOutput = true;
            //prog.StartInfo.CreateNoWindow = true;
            //prog.StartInfo.UseShellExecute = false;
            //prog.Start();

            Console.ReadKey();
        }

        static void PrintKeys(RegistryKey rkey)
        {

            // retrieve all the subkeys for the specified key.
            string[] names = rkey.GetSubKeyNames();

            int icount = 0;

            Console.WriteLine("subkeys of " + rkey.Name);
            Console.WriteLine("-----------------------------------------------");

            // print the contents of the array to the console.
            foreach (string s in names)
            {
                Console.WriteLine(s);

                //the following code puts a limit on the number of keys displayed.
                //comment it out to print complete list.
                icount++;
                if (icount >= 10)
                {
                    break;
                }
            }
        }
    }
}
