using System;

namespace stackPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackPost = new Post
            {
                Title = "This is header",
                Description = "Hello this is description of some text"
            };

            Console.WriteLine(stackPost.Title);
            Console.WriteLine(stackPost.Description);
            stackPost.UpVote();
            stackPost.DownVote();

            Console.WriteLine("Current votes for the post is " + stackPost.CurrentVotes());

            

        }
    }
}
