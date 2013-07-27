using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Utility.GetAllOutcomes();
            List<string> single = new List<string>();
            List<string> final = new List<string>();
            foreach (var option in list)
            {
                single = option.Split(' ').ToList();
                string dist = Utility.CalculateTotalDistance(single).ToString();
                final.Add(dist);
            }
            File.WriteAllLines(@"C:\Temp\distances.txt",final);
            Console.WriteLine("Done");
            Console.Read();


            //File.WriteAllLines(@"C:\Temp\outcomes.txt", list);
        }
    }
}
