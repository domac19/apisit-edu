using System;

namespace stackPost
{
    public class Post
    {
        public int counterVotes;
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime DateTime { get; }

        public int Votes()
        {
            return counterVotes;
        }
        public void UpVote()
        {
            counterVotes++;
        }
        public void DownVote()
        {
            counterVotes--;
        }
    }
}
