using LMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record UserWalletHistory
    {
        [Key]
        public int Id { get; set; }
        public int WalletId { get; set; }
        public UserWallet Wallet { get; set; }
        public WalletEnums TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
