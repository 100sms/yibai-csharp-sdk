using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Domain
{
    /*
     * 获取短信发送状态报告接口返回类型
     */
    public class SmsStatusReport
    {
        public long taskId { set; get; }

        public string mobile { set; get; }

        public string report { set; get; }

        public string reportTime { set; get; }
    }
}
