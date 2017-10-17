using Yibai.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api
{
    /*
     * Yibai客户端
     */
    public interface YibaiClient
    {
        List<SmsBatchSubmitResult> SmsBatchSubmit(List<SmsSubmit> submits);

        List<SmsStatusReport> SmsPullStatusReport();

        List<SmsReplyMessage> SmsPullReplyMessage();
    }
}
