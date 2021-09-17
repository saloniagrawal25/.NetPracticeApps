using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Post();
            p.Upvote();
            p.Upvote();
            p.Upvote();
            p.Upvote();
            p.Upvote();
            p.Upvote();
            p.Downvote();
            Console.WriteLine("Number of votes: {0}", p.GetCount());
        }
    }
}
