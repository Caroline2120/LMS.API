using LMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record InterswitchPaymentHistory
    {
        [Key]
        public int Id { get; set; }
        public string PaymentRef { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentStatusEnums Status { get; set; }
        public string UserId { get; set; }
        public Users User { get; set; }
        public decimal Amount { get; set; }
        public string PaymentLogId { get; set; }
        public string ItemCode { get; set; }

    }
}

