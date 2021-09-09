using System.IO;

namespace readingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFiles = (@"D:\Excercie\sortingNumbers\sortingNumbers.sln");  
            
            var someFiles = File.ReadAllText(textFiles).Length;

           

        }
    }
}
