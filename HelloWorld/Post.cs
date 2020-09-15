using System;
namespace HelloWorld
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; private set; }
        public DateTime Created { get; }

        public Post(string title, string desc)
        {
            this.Title = title;
            this.Description = desc;
            this.Votes = 0;
            this.Created = DateTime.Now;
        }

        public int UpVote()
        {
            this.Votes++;
            return this.Votes;
        }

        public int DownVote()
        {
            this.Votes--;
            return this.Votes;
        }
    }
}


//It should have properties for title, description and the date/time it was created.
//We should be able to up-vote or down-vote a post. We should also be able to see the current vote value.
//You should not give the ability to set the Vote property from the outside