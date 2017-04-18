using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //Primary Key Property
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        //Navigation Property
        //Example of one-to-many (course-->Enrollment)
        public virtual ICollection<Enrollment>Enrollments { get; set; }
    }
}