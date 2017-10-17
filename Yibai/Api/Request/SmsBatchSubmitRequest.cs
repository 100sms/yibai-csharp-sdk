using Yibai.Api.Common;
using Yibai.Api.Domain;
using Yibai.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Request
{
    /*
     * 短信发送请求类型
     */
    public class SmsBatchSubmitRequest : YibaiRequest<SmsBatchSubmitResponse>
    {
        public List<SmsSubmit> submits { set; get; }

        public override string GetApiUrlPath()
        {
            return "/sms/batchSubmit";
        }
        public override Type GetResponseType()
        {
            return typeof(SmsBatchSubmitResponse);
        }
    }


}
