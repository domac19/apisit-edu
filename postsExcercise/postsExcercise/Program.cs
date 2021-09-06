using System;
using System.Collections.Generic;

namespace postsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameFriend = new List<string>() { };

            while (true)
            {
                Console.WriteLine("Enter different names or press Enter and exit! ");

                var inputText = Console.ReadLine();
                if (inputText == "")
                {
                    nameFriend.Add(inputText);
                    break;
                }
                if(nameFriend.Count > 0)
                {
                    Console.WriteLine("Likes your post:",  nameFriend[0]);
                }
                else if(nameFriend.Count >= 2)
                {
                    Console.WriteLine(nameFriend[0] + nameFriend[1]);
                }
                else
                {
                    Console.WriteLine(nameFriend);
                }
            }
        }
    }
}
