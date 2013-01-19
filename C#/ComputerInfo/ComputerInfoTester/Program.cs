using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceProcess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyComputer;
using Newtonsoft.Json;

namespace ComputerInfoTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer();
            Console.Write("Computer Name: " + myComputer.ComputerName);
            Console.Write("\nProcessor Architecture: " + myComputer.Architecture);
            Console.Write("\nUser Name: " + myComputer.UserName);
            Console.Write("\nWindows Version: " + myComputer.OSVersion);
            Console.Write("\n\n\n\nEnvironment Variables: \n");
            foreach (var enVar in myComputer.EnvironmentVariables)
            {
                Console.WriteLine(enVar);
            }
            Console.Write("\n\n\n\nServices: \n");

            string json = JsonConvert.SerializeObject(myComputer);
            Console.Write(json);
            //Process.Start("mstsc.exe", @"/v: " + myComputer.ComputerName);
            Console.Read();
        }
    }
}
