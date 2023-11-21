using LMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserData
    {
        [Key]
        public int Id { get; set; }
        public int DataId { get; set; }
        public tblData Data { get; set; }
        public string UserId { get; set; }
        public Users User { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string PhoneNumber { get; set; }
        public UserProgramPaymentStatusEnums PaymentStatus { get; set; }

    }
}
