using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //ID property is the "Primary Key property" and will always be treated as such in 
        //the DB associated with this class.
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        //Enrollments propert is a "navigation property"
        //Navigation properties hold entities, or properties, related to this entity, 
        //**in this case that would be the Enrollment properties related to student**
        //Navigation properties are usually made "virtual" to take advantage of "Lazy Loading"
        //ICollection is a list so that multiple Entities can be added or deleted throughout the project
        //Example of one-to-many (student-->Enrollment)
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}