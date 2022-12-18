using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment35
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sentBy, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SentBy = sentBy;
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2} - url {3}", this.ID, this.Title, this.SentBy, this.ImageURL);
        }
    }
}
