using Yibai.Api.Common;
using Yibai.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Request
{
    public class SmsPullReplyMessageRequest : YibaiRequest<SmsPullReplyMessageResponse>
    {
        public override string GetApiUrlPath()
        {
            return "/sms/pullReply";
        }
        public override Type GetResponseType()
        {
            return typeof(SmsPullReplyMessageResponse);
        }
    }
}
