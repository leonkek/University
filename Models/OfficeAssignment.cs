using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key,ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Location cannot be longer than 50 characters or shorter than 2 characters."),Display(Name = "Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}