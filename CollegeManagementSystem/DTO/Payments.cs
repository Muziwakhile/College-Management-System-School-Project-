using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem.DTO
{
    class Payments
    {
        public int PaymentId { get; set; }
        public int? StudentId { get; set; }
        public double? Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int? UserId { get; set; }
        
    }
}
