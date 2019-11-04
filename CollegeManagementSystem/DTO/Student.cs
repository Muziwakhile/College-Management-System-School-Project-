
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem.DTO
{
      class Student:Person
    {
      
        [Display(Name = "Postal Address")]
        public string PostalAddress { get; set; }
        public int? Semester { get; set; }

        [Display(Name = "Course ID")]
        public int? CourseId { get; set; }

        [Display(Name = "Status ID")]
        public int? StatusId { get; set; }
    }
}
