using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserReferralPaymentHistory
    {
        [Key]
        public int Id { get; set; }
        public int UserReferId { get; set; }
        public UserReferred UserRefer { get; set; }
        public int UserCourseId { get; set; }
        public UserCourses UserCourse { get; set; }
        public string PaymentRef { get; set; }
        public float Amount { get; set; }
        public float Earning { get; set; }
    }
}

