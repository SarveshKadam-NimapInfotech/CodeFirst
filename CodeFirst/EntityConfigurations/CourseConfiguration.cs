using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CodeFirst.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {


            //modelBuilder.Entity<Author>()
            //        .HasMany(e => e.Courses)
            //        .WithOptional(e => e.Author)
            //        .HasForeignKey(e => e.Author_Id);

            ToTable("tbl_Course");

            HasKey(c => c.Description); 


            HasMany(e => e.Tags)
            .WithMany(e => e.Courses)
            .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id"));


            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(255);



            Property(c => c.Description)
            .IsRequired()
            .HasMaxLength(2000);


            HasRequired(c => c.Author) // This is Navigation Properties each Course has one Author
            .WithMany(a => a.Courses)  // And each Author has many Courses
            .HasForeignKey(c => c.AuthorId)
            .WillCascadeOnDelete(false);


            HasMany(c => c.Tags)
            .WithMany(t => t.Courses)
            .Map(m =>
            {
                m.ToTable("CourseTags");
                m.MapLeftKey("CourseId");
                m.MapRightKey("TagId");
            });


            //HasRequired(c => c.Cover)
            //    .WithReqiredPrincipal(c => c.Courses);
        }
    }
}