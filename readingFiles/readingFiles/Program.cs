using System;
using System.IO;

namespace readingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFiles = File.ReadAllText(@"D:\Excercie\sortingNumbers\sortingNumbers.sln");
            Console.WriteLine(textFiles.Length);
        }
    }
}
