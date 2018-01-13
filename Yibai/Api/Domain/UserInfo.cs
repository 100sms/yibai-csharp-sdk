using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Domain
{
    /*
     * 用户信息的参数列表
     */
    public class UserInfo
    {

        public string username { set; get; }

        public string mobile { set; get; }

        public int smsBalance { set; get; }

        public long createdTime { set; get; }
    }
}
