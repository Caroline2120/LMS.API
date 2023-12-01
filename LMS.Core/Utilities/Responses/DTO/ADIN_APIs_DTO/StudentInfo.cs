using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Utilities.Responses.DTO.ADIN_APIs_DTO
{
    public class StudentInfo
    {
        public string StudentId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string MatricNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Programme { get; set; }
    }
}
