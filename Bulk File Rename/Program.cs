using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulk_File_Rename
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "D:\\Storage\\Temp";
            DirectoryInfo d = new DirectoryInfo(@directoryPath);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                File.Move(f.FullName, f.FullName.Replace(" ", ""));
            }
        }
    }
}
