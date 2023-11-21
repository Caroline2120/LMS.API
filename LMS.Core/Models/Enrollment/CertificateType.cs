using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record CertificateType
    {
        [Key]
        public int Id { get; set; }
        public string CertType { get; set; }
        public float Fee { get; set; }
    }
}
