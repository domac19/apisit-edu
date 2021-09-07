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
                    break;
                    nameFriend.Add(inputText);

                if(nameFriend.Count == 1)
                {
                    Console.WriteLine(nameFriend[0] + "likes your post");
                }
                else if(nameFriend.Count == 2)
                {
                    Console.WriteLine(nameFriend[0],  nameFriend[1] + "likes your post");
                }
                else if(nameFriend.Count > 2)
                {
                    Console.WriteLine(nameFriend[0], nameFriend[1],  nameFriend.Count + "likes your post");
                }
            }
        }
    }
}
