﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LMS.Core.Utilities.Enums;

namespace LMS.Core.Models.LMS
{
    public class AcademicYear
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public StatusEnums Status { get; set; }

    }
}
