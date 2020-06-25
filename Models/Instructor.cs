﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        [Required,Display(Name = "Last Name"),StringLength(50, MinimumLength = 2, ErrorMessage = "Last name cannot be longer than 50 characters or shorter than 2 characters.")]
        public string LastName { get; set; }

        [Required,Display(Name = "First Name"),StringLength(50, MinimumLength = 2, ErrorMessage = "First name cannot be longer than 50 characters or shorter than 2 characters."),Column("FirstName")]
        public string FirstMidName { get; set; }

        [Required,DataType(DataType.Date),Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}