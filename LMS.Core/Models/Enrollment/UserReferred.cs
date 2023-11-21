using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserReferred
    {
        [Key]
        public int Id { get; set; }
        public string ReferralId { get; set; }
        public Users Referral { get; set; }
        public string ReferredUserId { get; set; }
        public Users ReferredUser { get; set; }
        public int ReferralDiscount { get; set; }
        public int ReferredDiscount { get; set; }
    }
}
