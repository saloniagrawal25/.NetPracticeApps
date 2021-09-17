using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow
{
    class Post
    {
        private int _count = 0;
        public string title
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public DateTime CreationTime
        {
            get; set;
        }

        public void Upvote()
        {
            _count++;
        }

        public void Downvote()
        {
            _count--;
        }

        public int GetCount() => _count;
    }
}
