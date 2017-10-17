using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Domain
{
    /*
    * 短信批量发送接口的返回类型
    * 
    */
    public class SmsBatchSubmitResult
    {
        public int code { set; get; }

        public string message { set; get; }

        public string mobile { set; get; }

        public long taskId { set; get; }
    }
}
