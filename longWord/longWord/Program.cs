using System;
using System.IO;

namespace longWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var allText = File.ReadAllText(@"D:\document.rtf");

            string[] longWords = allText.Split(new[] { " " }, StringSplitOptions.None);
            string longWord = "";
            int numberWords = 0;
            foreach (String s in longWords)
            {
                if (s.Length > numberWords)
                {
                    longWord = s;
                    numberWords = s.Length;
                }
            }

            Console.WriteLine(longWord);
        }
    }
}
