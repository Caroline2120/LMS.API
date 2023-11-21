using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record AffiliateUserAccount
    {
        [Key]
        public int Id { get; set; }
        public int BankId { get; set; }
        public Banks Bank { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string UserId { get; set; }
        public Users User { get; set; }
    }
}
