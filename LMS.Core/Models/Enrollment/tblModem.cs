using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record tblModem
    {
        [Key]
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        // public string Duration { get; set; }
        public string Bundle { get; set; }
        public string Amount { get; set; }

    }
}