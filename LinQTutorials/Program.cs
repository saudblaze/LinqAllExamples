using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTutorials
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string path = @"C:/windows";
        //    ListOAllFilesWithoutLinQ(path);
        //    Console.WriteLine("******");
        //    ListOAllFilesLinQ(path);
        //}

        private static void ListOAllFilesLinQ(string path)
        {
            //method 1
            //var query = from file in new DirectoryInfo(path).GetFiles()
            //            orderby file.Length descending
            //            select file;

            //foreach (var file in query.Take(5))
            //{
            //    Console.WriteLine($"{file.Name,25} - {file.Length,10:N0}");
            //}
            //Console.WriteLine("******");
            //method 2

            var Query2 = new DirectoryInfo(path).GetFiles().OrderByDescending(x => x.Length).Take(5);
            foreach (var file in Query2)
            {
                Console.WriteLine($"{file.Name,25} - {file.Length,10:N0}");
            }
            Console.ReadLine();
        }

        private static void ListOAllFilesWithoutLinQ(string path)
        {
            DirectoryInfo objDir = new DirectoryInfo(path);
            FileInfo[] objFile = objDir.GetFiles();
            Array.Sort(objFile,new FileInfoComparer());
            //foreach (FileInfo file in objFile)
            //{
            //    Console.WriteLine($"{file.Name,25} - {file.Length,10:N0}");
            //}
            for (int I = 0; I < 5; I++)
            {
                FileInfo objfileInfo = objFile[I];
                Console.WriteLine($"{objfileInfo.Name,25} - {objfileInfo.Length,10:N0}");
            }
            Console.ReadLine();
        }
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
