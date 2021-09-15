using System;

namespace stackPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackPost = new Post();
            Console.WriteLine("Write your post!");
            stackPost.UpVote();
            stackPost.DownVote();
            Console.WriteLine(stackPost.Votes());
        }
    }
}
