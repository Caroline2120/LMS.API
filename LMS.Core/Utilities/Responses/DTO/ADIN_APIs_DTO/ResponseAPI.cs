using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Utilities.Responses.DTO.ADIN_APIs_DTO
{
    public class ResponseAPI
    {
        public int TotalRecord { get; set; } = 0;
        public int Count { get; set; } = 0;
        public Data data { get; set; }
    }
    public class Data
    {
        public string Surname { get; set; }    
        public string Firstname { get; set; }    
        public string StudentId { get; set; }    
        public string Othernames { get; set; }    
        public string MatricNo { get; set; }    
        public string Gender { get; set; }    
        public string MaritalStatus { get; set; }    
        public string BirthDate { get; set; }    
        public string Lga { get; set; }    
        public string StateOfOrigin { get; set; }    
        public string Religion { get; set; }    
        public string ContactAddress { get; set; }    
        public string Email { get; set; }    
        public string HomeAddress { get; set; }    
        public string Phone { get; set; }    
        public string Genotype { get; set; }    
        public string BloodGroup { get; set; }    
        public string NextOfKin { get; set; }    
        public string NextOfKinAddress { get; set; }    
        public string NextOfKinPhone { get; set; }    
        public string Programme { get; set; }    
        public string ProgrammeType { get; set; }    
        public string Faculty { get; set; }    
        public string Department { get; set; }    
        public string CourseOfStudy { get; set; }    
        public string Level { get; set; }    
        public string PhotoUrl { get; set; }    
        public string Status { get; set; }    
        public string StudentStatus { get; set; }    
    }
}
