using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record ProgramCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // public int ProgramId { get; set; }
        //public Programs Program { get; set; }
        public int InstitutionId { get; set; }
        public Institutions Institution { get; set; }
    }
}