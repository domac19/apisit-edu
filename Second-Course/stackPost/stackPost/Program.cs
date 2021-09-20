using System;

namespace stackPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackPost = new Post
            {
                Title = "Welcome to posts!",
                Description = "In this example you should see how many votes are here!",
            };

            Console.WriteLine(stackPost.Title);
            Console.WriteLine(stackPost.Description);
            stackPost.UpVote();

            Console.WriteLine("Current votes for the post is " + stackPost.CurrentVotes());

            

        }
    }
}
