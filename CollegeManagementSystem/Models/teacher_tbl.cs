//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class teacher_tbl
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string PIN { get; set; }
        public Nullable<int> StatusId { get; set; }
    
        public virtual status_tbl status_tbl { get; set; }
    }
}
