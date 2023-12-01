using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Utilities
{
    public class ApiSettings
    {
        public string Key { get; init; }
        public string Issuer { get; init; }
        public string Audience { get; init; }
        public long TokenExpireTime { get; set; } = 1;

    }
}
