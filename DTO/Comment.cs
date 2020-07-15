using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Comment
    {
        public string CommentID { get; set; }
        public string NewID { get; set; }
        public string CommenterName { get; set; }
        public string CommenterEmail { get; set; }
        public string Content { get; set; }
        public string Approved { get; set; }

        public Comment()
        {

        }
        public Comment(string commentID, string newID, string commenterName, string commenterEmail, string content, string approved)
        {
            this.CommentID = commentID;
            this.NewID = newID;
            this.CommenterName = commenterName;
            this.CommenterEmail = commenterEmail;
            this.Content = content;
            this.Approved = approved;
        }
    }
}
