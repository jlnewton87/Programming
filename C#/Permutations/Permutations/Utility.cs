using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Permutations
{
    public static class Utility
    {
       public static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetCombinations(list, length - 1)
                .SelectMany(t => list, (t1, t2) => t1.Concat(new T[] { t2 }));
        }

       public static List<string> GetAllOutcomes()
       {
           List<string> stations = new List<string>();
           stations.Add("Counter");
           stations.Add("Sink");
           stations.Add("Stove");
           stations.Add("Fridge");
           stations.Add("Storage");
           var permutations = Utility.GetCombinations<string>(stations, 5);
           List<string> lines = new List<string>();
           string permu;
           foreach (var perm in permutations)
           {
               permu = "";
               foreach (string station in perm)
               {
                   string thisStation = station + " ";
                   permu += thisStation;
               }
               lines.Add(permu);
           }
           List<string> hack = new List<string>();
           List<string> newLines = new List<string>();
           foreach (var perm in lines)
           {
               newLines.Add(perm);
               hack = perm.Split(' ').ToList();
               if (hack.Count != hack.Distinct().Count())
               {
                   newLines.Remove(perm);
               }

           }
           return newLines;
       }
       public static double Distance(int station1, int station2)
       {
           int s1, s2;
           if (station1 > station2)
           {
               s1 = station2;
               s2 = station1;
           }
           else
           {
               s1 = station1;
               s2 = station2;
           }
           if ((s1 == 1) & (s2 == 2))
           {
               return 4;
           }
           if ((s1 == 1) & (s2 == 3))
           {
               return 6.3;
           }
           if ((s1 == 1) & (s2 == 4))
           {
               return 5.7;
           }
           if ((s1 == 1) & (s2 == 5))
           {
               return 4;
           }
           if ((s1 == 2) & (s2 == 3))
           {
               return 2.8;
           }
           if ((s1 == 2) & (s2 == 4))
           {
               return 4;
           }
           if ((s1 == 2) & (s2 == 5))
           {
               return 5.7;
           }
           if ((s1 == 3) & (s2 == 4))
           {
               return 2.8;
           }
           if ((s1 == 3) & (s2 == 5))
           {
               return 6.3;
           }
           if ((s1 == 4) & (s2 == 5))
           {
               return 4;
           }
           else return 0;
       }
       public static double CalculateTotalDistance(List<string> orderOfStations)
       {
           double distance = 0;
           //counter to fridge
           distance += Distance(orderOfStations.IndexOf("Counter")+1, orderOfStations.IndexOf("Fridge")+1) * 12;
           //counter to sink
           distance += Distance(orderOfStations.IndexOf("Counter")+1, orderOfStations.IndexOf("Sink")+1) * 34;
           //counter to storage
           distance += Distance(orderOfStations.IndexOf("Counter")+1, orderOfStations.IndexOf("Storage")+1) * 31;
           //counter to stove
           distance += Distance(orderOfStations.IndexOf("Counter")+1, orderOfStations.IndexOf("Stove")+1) * 32;
           //fridge to counter
           distance += Distance(orderOfStations.IndexOf("Fridge")+1, orderOfStations.IndexOf("Counter")+1) * 29;
           //fridge to sink
           distance += Distance(orderOfStations.IndexOf("Fridge")+1, orderOfStations.IndexOf("Sink")+1) * 23;
           //fridge to stove
           distance += Distance(orderOfStations.IndexOf("Fridge")+1, orderOfStations.IndexOf("Stove")+1) * 28;
           //sink to counter
           distance += Distance(orderOfStations.IndexOf("Sink")+1, orderOfStations.IndexOf("Counter")+1) * 24;
           //sink to fridge
           distance += Distance(orderOfStations.IndexOf("Sink")+1, orderOfStations.IndexOf("Fridge")+1) * 23;
           //sink to stove
           distance += Distance(orderOfStations.IndexOf("Sink")+1, orderOfStations.IndexOf("Stove")+1) * 14;
           //storage to counter
           distance += Distance(orderOfStations.IndexOf("Storage")+1, orderOfStations.IndexOf("Counter")+1) * 12;
           //storage to sink
           distance += Distance(orderOfStations.IndexOf("Storage")+1, orderOfStations.IndexOf("Sink")+1) * 27;
           //storage to stove
           distance += Distance(orderOfStations.IndexOf("Storage")+1, orderOfStations.IndexOf("Stove")+1) * 20;
           //stove to counter
           distance += Distance(orderOfStations.IndexOf("Stove")+1, orderOfStations.IndexOf("Counter")+1) * 24;
           //stove to fridge
           distance += Distance(orderOfStations.IndexOf("Stove")+1, orderOfStations.IndexOf("Fridge")+1) * 26;
           return distance;
       }
    }
}
