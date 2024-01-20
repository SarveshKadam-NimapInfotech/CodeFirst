using CodeFirst.EntityConfigurations;
using CodeFirst.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst
{
    public partial class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());

            // Now this below code is been shfited into the Entity Configuration folder inside the configuration Class soo the above line of code is use to reference it.
             
            //modelBuilder.Entity<Author>()
            //    .HasMany(e => e.Courses)
            //    .WithOptional(e => e.Author)
            //    .HasForeignKey(e => e.Author_Id);

            //modelBuilder.Entity<Course>()
            //    .HasMany(e => e.Tags)
            //    .WithMany(e => e.Courses)
            //    .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id"));

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Name)
            //    .IsRequired()
            //    .HasMaxLength(255)

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Description)
            //    .IsRequired()
            //    .HasMaxLength(2000)

            //modelBuilder.Entity<Course>()
            //    .HasRequired(c => c.Author) // This is Navigation Properties each Course has one Author
            //    .WithMany(a => a.Courses)  // And each Author has many Courses
            //    .HasForeignKey(c => c.AuthorId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses)
            //    .Map(m => 
            //    {
            //        m.ToTable("CourseTags");
            //        m.MapLeftKey("CourseId");
            //        m.MapRightKey("TagId");
            //    });

            //modelBuilder.Entity<Course>()
            //    .HasRequired(c => c.Cover)
            //    .WithReqiredPrincipal(c => c.Courses)

            //base.OnModelCreating(modelBuilder);

        }
    }
}
