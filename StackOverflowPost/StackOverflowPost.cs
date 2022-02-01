using System;

namespace StackOverflowPost
{
    class StackOverflowPost
    {
        private string _postBody;
        private string _title;
        private DateTime _createdDate;
        private int _rank;

        public void CreatePost()
        {
            Console.WriteLine("type a new title."); 
            var PostTitle = Console.ReadLine();

            Console.WriteLine("Write your content.");
            var PostBody = Console.ReadLine();

            _title = PostTitle;
            _postBody = PostBody;
            _createdDate = DateTime.Now;

            Console.WriteLine($"You created a post called, \"{PostTitle}.\"");
        }

        public void ReadPost()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Written on: {_createdDate}");
            Console.WriteLine($"Post: {_postBody}");
        }

        public void Vote()
        {
            Console.WriteLine("Please indicate whether you would like to upvote (U) or downvote (D) this post");
            var vote = Console.ReadLine();
            
            if (vote is not ("u") && vote is not ("d"))
            {
                throw new ArgumentException("Enter \"u\" for upvote; enter \"d\" for downvote. Invalid entry.");
            }

            if (vote == "u")
            {
                _rank++;
            }

            if (vote == "d")
            {
                _rank--;
            }

            Console.WriteLine($"This post's rank is: {_rank}");
        }
    }
}