using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Common
{
    /*
     * 基础请求信息
     */
    public abstract class YibaiRequest<T>
    {
        public string apikey { set; get; }

        public abstract string GetApiUrlPath();

        public abstract Type GetResponseType();
    }
    
}
