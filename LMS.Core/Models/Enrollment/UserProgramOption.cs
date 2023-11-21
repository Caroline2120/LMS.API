using LMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserProgramOption
    {
        [Key]
        public int Id { get; set; }
        public int ProgramOptionId { get; set; }
        public ProgramOptions ProgramOption { get; set; }
        public DateTime RegDate { get; set; }
        public string UserId { get; set; }
        public UserProgramStatusEnums ProgramStatus { get; set; }
        public UserProgramPaymentStatusEnums PaymentStatus { get; set; }
        public Users User { get; set; }
    }
}

