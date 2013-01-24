using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace ZipTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = "C:\\Users\\josh\\Documents\\GitHub\\Programming\\HTML\\3260";
            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(directory);
                zip.Save(directory + "\\3260.zip");
            }

        }
    }
}
