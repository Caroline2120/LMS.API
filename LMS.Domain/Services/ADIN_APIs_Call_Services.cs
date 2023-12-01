using LMS.Core.Interfaces;
using LMS.Core.Utilities.Responses.DTO.ADIN_APIs_DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Services
{
    public class ADIN_APIs_Call_Services : IADIN_APIs
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ADIN_APIs_Call_Services(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Tuple<StudentInfo, HttpStatusCode>> GetStudentByEmail(string Email)
        {
            try 
            {
                var studentInfo = await _httpClientFactory.CreateClient("ADIN_APIs").GetFromJsonAsync<ResponseAPI>($"studentinfo/{Email}");

                if (studentInfo.data != null)
                {
                    var stInfo = new StudentInfo
                    {
                        Surname = studentInfo.data.Surname,
                        Email = studentInfo.data.Email,
                        Firstname = studentInfo.data.Firstname,
                        MatricNo = studentInfo.data.MatricNo,
                        Othernames = studentInfo.data.Othernames,
                        Phone = studentInfo.data.Phone,
                        Programme = studentInfo.data.Programme,
                        StudentId = studentInfo.data.StudentId
                    };

                    return new Tuple<StudentInfo, HttpStatusCode>( stInfo, HttpStatusCode.Found);
                }
                else
                {
                    return new Tuple<StudentInfo, HttpStatusCode>(null, HttpStatusCode.NotFound);
                }
            }
            catch (Exception ex)
            {
                return new Tuple<StudentInfo, HttpStatusCode>(null, HttpStatusCode.NotFound);
            }
            
        }
    }
}
