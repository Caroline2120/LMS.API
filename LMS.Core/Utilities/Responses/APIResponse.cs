using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Utilities.Responses
{
    public class APIResponse
    {
        public HttpStatusCode status { get; set; }
        public bool successful { get; set; }
    }
    public class APIResponses<T> : APIResponse
    {
        /// <summary>
        /// The items being returned
        /// </summary>
        public T data { get; set; }
        public string message { get; set; }

        public APIResponses(T items, HttpStatusCode statusCode = HttpStatusCode.OK, bool isSuccess = true, string message = null)
        {
            data = items;
            status = statusCode;
            successful = isSuccess;
            this.message = message;
        }
    }
    public class APIResponseList<T> : APIResponse
    {
        /// <summary>
        /// The items being returned
        /// </summary>
        public IEnumerable<T> data { get; set; }

        public APIResponseList(IEnumerable<T> items, HttpStatusCode statusCode = HttpStatusCode.OK, bool isSuccess = true)
        {
            data = items;
            status = statusCode;
            successful = isSuccess;
        }
    }
    public class APIErrorResponseList : APIResponse
    {
        /// <summary>
        /// The items being returned
        /// </summary>
        public IEnumerable<string> ErrorMessages { get; set; }

        public APIErrorResponseList(IEnumerable<string> errors, HttpStatusCode statusCode, bool isSuccess = false)
        {
            ErrorMessages = errors;
            status = statusCode;
            successful = isSuccess;
        }
    }
}
