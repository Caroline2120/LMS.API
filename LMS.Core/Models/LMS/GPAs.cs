using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.LMS
{
    public class GPAs
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }    
        public AcademicYear Session { get; set; }
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }
        public float GPA { get; set; }
    }
}
