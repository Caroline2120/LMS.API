using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Utilities
{
    public class Enums
    {
        public enum StatusEnums
        {
            [Description("Active")]
            Active = 1,
            [Description("Inactive")]
            Inactive = 2
        }
    }
}
