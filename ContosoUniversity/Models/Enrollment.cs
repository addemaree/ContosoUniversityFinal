using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //Primary Key 
        public int EnrollmentID { get; set; }

        //Foreign Key
        //Corresponding nav property is Course
        public int CourseID { get; set; }

        //Foreign Key
        //Corresponding nav property is Student
        public int StudentID { get; set; }

        //? symbols that the Grade property is nullable
        //this means that it can be empty because the grade might not have been given yet or isn't known
        public Grade? Grade { get; set; }

        //Corresponding Entities
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}