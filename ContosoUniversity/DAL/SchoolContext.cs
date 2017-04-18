using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        //                          Name of Connection String
        public SchoolContext() : base("SchoolContext")
        {

        }

        //**Ask about ommitting the Enrollment and Course entity set
        //**Notes said that because Enrollment comes from student and course from enrollment it would work, so
        //**Does that mean that I can just put Student in the entity set?

        //DbSet<> = Entity set.
        //<""> = class the Entity derives from database table

        //  Entity Set      DB Table
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        //This method keeps the tables from pluralizing the names. So courses will be course etc..
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}