using System;

namespace stackPost
{
    public class Post
    {
        private int _counterVotes;
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime DateTime { get; }

        public int CurrentVotes()
        {
            return _counterVotes;
        }
        public void UpVote()
        {
            _counterVotes++;
        }
        public void DownVote()
        {
            _counterVotes--;     
        }
    }
}
