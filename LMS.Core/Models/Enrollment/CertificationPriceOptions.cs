﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record CertificationPriceOptions
    {
        [Key]
        public int Id { get; set; }
        public int CertificationId { get; set; }
        public Certifications Certification { get; set; }
        public DateTime ExamDate { get; set; }
        public float Amount { get; set; }
        public float Charges { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
