using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem.DTO
{
    class Teacher:Person
    {
        public string PIN { get; set; }


        [Display(Name = "Status ID")]
        public int? StatusId { get; set; }
    }
}
