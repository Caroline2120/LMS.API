using LMS.Core.Utilities.Responses.DTO;
using LMS.Core.Utilities.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public  interface IAuthentication
    {
        Task<AuthenticationResponse> jwtToken(LoginDTO user);
    }
}
