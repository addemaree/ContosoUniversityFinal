using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //ID property is the "Primary Key property" and will always be treated as such in 
        //the DB associated with this class.
        public int ID { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength =1)]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }


        //Enrollments propert is a "navigation property"
        //Navigation properties hold entities, or properties, related to this entity, 
        //**in this case that would be the Enrollment properties related to student**
        //Navigation properties are usually made "virtual" to take advantage of "Lazy Loading"
        //ICollection is a list so that multiple Entities can be added or deleted throughout the project
        //Example of one-to-many (student-->Enrollment)
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}