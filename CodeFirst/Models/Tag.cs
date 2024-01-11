using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Tag
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; } // There is Many to Many relation between Tag and Course ( So the Tag can be applied to Many Courses and a Course can have multiple tags )

    }
}