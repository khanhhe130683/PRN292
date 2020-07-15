using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class News
    {
        public string NewId { get; set; }
        public string AuthorID { get; set; }
        public string CategoryID { get; set; }
        public string PublishDate { get; set; }
        public string Content { get; set; }
        public string CoverImage { get; set; }

        public News()
        {

        }
        public News(string newID, string authorID, string categoryID, string publishdate, string content, string coverimage)
        {
            this.NewId = newID;
            this.AuthorID = authorID;
            this.CategoryID = categoryID;
            this.PublishDate = publishdate;
            this.Content = content;
            this.CoverImage = coverimage;
        }
    }
}
