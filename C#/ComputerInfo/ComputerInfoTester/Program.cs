using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyComputer;

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
            //Process.Start("mstsc.exe", @"/v: " + myComputer.ComputerName);
            Console.Read();
        }
    }
}
