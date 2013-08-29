using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RecordCount
{
    class FileCount
    {
        public FileCount(string path, bool hasHeader)
        {
            FileName = Path.GetFileName(path);
            string[] lines2 = File.ReadAllLines(path);
            List<string> lines = lines2.ToList();
            lines.RemoveAll(x => x.Length < 1);

            if (hasHeader)
            {
                int count = lines.Count - 1;
                Count = count.ToString();
            }
            else
            {
                Count = lines.Count.ToString();
            }
        }
        public string FileName { get; set; }
        public string Count { get; set; }
    }
}
