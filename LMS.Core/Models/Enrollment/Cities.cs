using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record Cities
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public States State { get; set; }
    }
}

