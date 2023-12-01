using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.LMS
{
    public class StudentClasses
    {
        [Key]
        public int Id { get; set; }
        public int CourseEnrollmentId { get; set; }
        public CourseEnrollment CourseEnrollment { get; set; }
        public DateTime ClassDateTime { get; set; }
    }
}
