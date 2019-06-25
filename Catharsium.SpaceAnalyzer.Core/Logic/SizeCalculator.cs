using System;
using System.IO;
using Catharsium.SpaceAnalyzer.Core.Interfaces;

namespace Catharsium.SpaceAnalyzer.Core.Logic
{
    public class SizeCalculator : ISizeCalculator
    {
        public long GetSize(DirectoryInfo directory)
        {
            long result = 0;
            foreach (var file in directory.GetFiles()) {
                try {
                    result += this.GetSize(file);
                }
                catch (Exception ex) {
                    Console.WriteLine($"{ex.GetType().Name} for {file.FullName}");
                }
            }

            foreach (var subDir in directory.GetDirectories()) {
                try {
                    result += this.GetSize(subDir);
                }
                catch (Exception ex) {
                    Console.WriteLine($"{ex.GetType().Name} for {subDir.FullName}");
                }
            }

            return result;
        }


        public long GetSize(FileInfo file)
        {
            return file.Length;
        }
    }
}