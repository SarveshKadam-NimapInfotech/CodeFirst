using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; } // There is One to Many relation betweeen Author and Course ( An Author can have many courses but each course is created by only one author )
    }

}