using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDumper
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"" + Console.ReadLine());
            DirectoryInfo output = new DirectoryInfo(@"" + Console.ReadLine());
            FileInfo[] Files = directory.GetFiles();

            Console.WriteLine();

            foreach (FileInfo item in Files)
            {
                Console.WriteLine("Dumping file: " + item.Name);
                Console.WriteLine();
                Byte[] toDump = File.ReadAllBytes(item.FullName);
                string byteText = Convert.ToBase64String(toDump);

                Console.WriteLine("Writing File: " + output.FullName + "/" + item.FullName + ".txt");
                File.WriteAllText(output.FullName + "\\" + item.Name + ".txt", byteText);
            }
        }
    }
}
