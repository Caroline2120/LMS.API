using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Utilities.Responses
{
    internal class ResponseMessages
    {
        public static string DEFAULT_ERROR_MESSAGE = "Could not complete request. Please retry later, or contact the support team.";

       
        // Status
        public static string PENDING = "Pending";
        public static string APPROVED = "Approved";
        public static string SUCCESSFUL = "Successful";
    }
}
