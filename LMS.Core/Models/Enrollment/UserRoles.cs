using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public class UserRoles : IdentityUserRole<string>
    {
        public string StudentId { get; set; }
    }
}
