using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Common
{
    /*
     * 基础响应信息
     */
    public abstract class YibaiResponse<T>
    {
        private const int SUCCESS = 200;

        public int code { set; get; }

        public string message { set; get; }

        public T response { set; get; }

        public bool IsSuccess()
        {
            return code == SUCCESS;
        }
    }
}
