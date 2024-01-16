using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Tag> Tags { get; set; }


        // Since We have given the the name of connection string diferent , we have broken the convention so we have to tell the Entity FrameWork explicity what the name of connection string is
        //so here we create a contructor and simply call the base contructor
        public PlutoContext()
            : base("name =DefaultConnection")
        {

        }
    }
}