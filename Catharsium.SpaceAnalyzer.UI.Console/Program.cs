using Catharsium.SpaceAnalyzer.Core.Logic;
using System.IO;

namespace Catharsium.SpaceAnalyzer.UI.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sizeCalculator = new SizeCalculator();

            var d = new DirectoryInfo("C:\\");
            var bytes = sizeCalculator.GetSize(d);
            var kBytes = bytes / 1024;
            bytes %= 1024;
            var mBytes = kBytes / 1024;
            kBytes %= 1024;
            var gBytes = mBytes / 1024;
            mBytes %= 1024;
            System.Console.WriteLine($"{gBytes} GB, {mBytes} MB, {kBytes} KB, {bytes} B");
            System.Console.ReadLine();
        }
    }
}