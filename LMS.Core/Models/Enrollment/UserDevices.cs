using LMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserDevices
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        //public tblModem Modem { get; set; }
        public string UserId { get; set; }
        public Users User { get; set; }
        public DateTime RegisteredDate { get; set; }
        public UserProgramPaymentStatusEnums PaymentStatus { get; set; }

    }
}

