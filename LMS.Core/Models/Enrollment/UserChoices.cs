using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserChoices
    {
        [Key]
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public Programs Program { get; set; }
        public int? InstitutionId { get; set; }
        public Institutions Institution { get; set; }
        public int? CourseId { get; set; }
        public Courses Course { get; set; }
        public string UserId { get; set; }
        public Users User { get; set; }
    }
}
