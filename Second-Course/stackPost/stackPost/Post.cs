using System;

namespace stackPost
{
    public class Post
    {
        public int counterVotes;
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime DateTime { get; }

        public int CurrentVotes()
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
