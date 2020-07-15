using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Author
    {
        public string AuthorID { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }

        public Author()
        {

        }

        public Author(string id, string displayname, string username)
        {
            this.AuthorID = id;
            this.DisplayName = displayname;
            this.UserName = username;
        }
    }
}
