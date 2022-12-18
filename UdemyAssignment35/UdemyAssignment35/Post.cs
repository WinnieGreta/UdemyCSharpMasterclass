using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment35
{
    internal class Post
    {
        private static int currentPostID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SentBy { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SentBy = "Panjuta";
        }

        public Post(string title, bool isPublic, string sentBy)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SentBy = sentBy;
        }

        protected int GetNextID()
        {
            return ++currentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SentBy);
        }
    }
}
