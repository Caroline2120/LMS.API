using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data
{
   public class LMSDbContext : IdentityDbContext
    {
        public LMSDbContext(DbContextOptions<LMSDbContext> options)
            : base(options)
        {
        }

    }
}
