using LMS.Core.Utilities.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public interface IUsers
    {
        Task<APIResponses<AuthenticationResponse>> Login(string Email, string Password);
    }
}
