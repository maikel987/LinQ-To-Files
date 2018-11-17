using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // google: 101 Linq
            DirectoryInfo dir = new DirectoryInfo("C:/Users/Owner/Documents/Visual Studio 2015/Projects/C#");

            var newest = (from a in dir.GetFiles() orderby a.LastWriteTimeUtc select a).ToList();

            var newNew = newest.OrderByDescending((c) => c.LastWriteTime);

            //foreach (var item in newNew)
            //{
            //    Console.WriteLine($"{item.Name}  {item.LastWriteTime}");
            //}


            IEnumerable<FileInfo> top = newNew.Take(10);

            Console.WriteLine("top 10: ");


            foreach (var item in top)
            {
                Console.WriteLine($"{item.Name}  {item.LastWriteTime}");
                 
            }

            //DirectoryInfo baba = newest.FirstOrDefault((d) => d.LastWriteTime == newest.Max((a) => a.LastWriteTime));

            //Console.WriteLine();
            //Console.WriteLine($"{baba.Name}  {baba.LastWriteTime}");










        }
    }
}
