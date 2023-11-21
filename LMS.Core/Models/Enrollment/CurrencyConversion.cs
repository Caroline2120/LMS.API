using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record CurrencyConversion
    {
        [Key]
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public float ConversionRate { get; set; }
    }
}

