using LMS.Core.Utilities.Responses.DTO.ADIN_APIs_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public interface IADIN_APIs
    {
        Task<Tuple<StudentInfo, HttpStatusCode>> GetStudentByEmail(string Email);
    }
}
