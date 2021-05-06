using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProgrammationConformit.Infrastructures.Wrappers
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool Succeded { get; set; }
        public string[] Errors { get; set; }
        public string Message { get; set; }

        public Response()
        {
        }

        public Response(T data)
        {
            Succeded = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }
    }
}
