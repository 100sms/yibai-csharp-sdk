using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Domain
{
    /*
     * 发送短信接口提交的参数列表
     */
    public class SmsSubmit
    {
        public SmsSubmit(string mobile, string message)
        {
            this.mobile = mobile;
            this.message = message;
        }

        public string mobile { set; get; }

        public string message { set; get; }
    }
}
