using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.LMS
{
    public class CourseEnrollment
    {
        [Key]
        public int Id { get; set; }
        public string StudentId { get; set; }    
        public string CourseCode { get; set; }    
        public int CourseUnit { get; set; }    
        public string CourseTitle { get; set; }    
        public string RegDate { get; set; }    
        public int SemesterId { get; set; } 
        public Semester Semester { get; set; }
        public int SessionId { get; set; }
        public AcademicYear Session { get; set; }

    }
}
