﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem.DTO
{
     abstract class Person
    {
        public  int ID { get; set; }
        public  string Name { get; set; }
        public  string Surname { get; set; }
        public  string Gender { get; set; }
        public  string Cell { get; set; }
        public  string Email { get; set; }
    }
}
