using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record MarketerCode
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
