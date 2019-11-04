using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem.DTO
{
    class Gaurdian:Person
    {
        [Display( Name = "Status ID")]
        public int StudentId { get; set; }
    }
}
