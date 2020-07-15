using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Category
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryUrl { get; set; }

        public Category()
        {

        }
        public Category(string categoryID, string categoryName, string url)
        {
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
            this.CategoryUrl = url;
        }
    }
}
