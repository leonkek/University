using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name cannot be longer than 50 characters or shorter than 3 characters.")]
        public string Name { get; set; }

        [DataType(DataType.Currency),Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date),Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}