using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Models.Enrollment
{
    public record Currency
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string major_symbol { get; set; }
    }
}
