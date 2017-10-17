using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Domain
{
    /*
     * 回去短信回复接口返回类型
     */
    public class SmsReplyMessage
    {
        public string moblie { set; get; }

        public string message { set; get; }

        public long replyTime { set; get; }
    }
}
