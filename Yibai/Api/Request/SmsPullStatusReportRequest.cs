using Yibai.Api.Common;
using Yibai.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Request
{
    public class SmsPullStatusReportRequest : YibaiRequest<SmsPullStatusReportResponse>
    {
        public override string GetApiUrlPath()
        {
            return "/sms/pullStatusReport";
        }
        public override Type GetResponseType()
        {
            return typeof(SmsPullStatusReportResponse);
        }
    }
}
