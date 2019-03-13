using System;
using System.IO;

namespace Catharsium.SpaceAnalyzer.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var d = new DirectoryInfo("C:\\");
            var bytes = GetFolderSize(d);
            var kbytes = bytes/1024;
            bytes %= 1024;
            var mbytes = kbytes/1024;
            kbytes %= 1024;
            var gbytes = mbytes/1024;
            mbytes %= 1024;
            System.Console.WriteLine($"{gbytes} GB, {mbytes} MB, {kbytes} KB, {bytes} B");
            System.Console.ReadLine();
        }


        public static long GetFolderSize(DirectoryInfo directory)
        {
            long result = 0;
            foreach (var file in directory.GetFiles())
            {
                try
                {
                    result += GetFileSize(file);
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine($"{ex.GetType().Name} for {file.FullName}");
                }
            }
            foreach (var subDir in directory.GetDirectories())
            {
                try
                {
                    result += GetFolderSize(subDir);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"{ex.GetType().Name} for {subDir.FullName}");
                }
            }
            return result;
        }


        public static long GetFileSize(FileInfo file)
        {
            return file.Length;
        }
    }
}