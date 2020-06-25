using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Last Name"),Required,StringLength(50, MinimumLength = 2, ErrorMessage = "Last name cannot be longer than 50 characters or shorter than 2 characters.")]
        public string LastName { get; set; }
        [Display(Name = "First Name"),Required,StringLength(50, MinimumLength = 2, ErrorMessage = "First name cannot be longer than 50 characters or shorter than 2 characters."),Column("FirstName")]
        public string FirstMidName { get; set; }
        [Display(Name = "Enrollment Date"),Required,DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}