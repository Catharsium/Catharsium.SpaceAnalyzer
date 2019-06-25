using System.IO;

namespace Catharsium.SpaceAnalyzer.Core.Interfaces
{
    public interface ISizeCalculator
    {
        long GetSize(DirectoryInfo directory);
        long GetSize(FileInfo file);
    }
}