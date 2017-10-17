using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Common
{
    public class YibaiApiException : YibaiException
    {

        public int code{get ;set ;}

        public string message{get;set;}

        public YibaiApiException(int code, string message)
        {
            this.code = code;
            this.message = message;
        }
    }
}
