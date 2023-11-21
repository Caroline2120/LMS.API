using LMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserCertifications
    {
        [Key]
        public int Id { get; set; }
        public int CertificationPriceOptionId { get; set; }
        public CertificationPriceOptions CertificationPriceOption { get; set; }
        public string UserId { get; set; }
        public Users User { get; set; }
        public DateTime RegisteredDate { get; set; }
        public UserCourseStatusEnums Status { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool CertificateIssued { get; set; } = false;
        public DateTime? CertificateIssuedDate { get; set; }
        public UserProgramPaymentStatusEnums PaymentStatus { get; set; }

    }
}

