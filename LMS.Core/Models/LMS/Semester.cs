using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LMS.Core.Utilities.Enums;

namespace LMS.Core.Models.LMS
{
    public class Semester
    {
        [Key]
        public int Id { get; set; }
        //public int AcademicYearId { get; set; }
        //public AcademicYear AcademicYear { get; set; }
        public string Name { get; set; }
        public StatusEnums Status { get; set; }
    }
}
