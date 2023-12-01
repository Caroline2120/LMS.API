using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.LMS
{
    public class Grades
    {
        [Key]
        public int Id { get; set; }
        public int StudentClassId { get; set; }
        public StudentClasses StudentClass { get; set; }
        public float Grade { get; set; }
    }
}
