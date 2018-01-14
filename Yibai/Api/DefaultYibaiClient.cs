using Newtonsoft.Json;
using Yibai.Api.Common;
using Yibai.Api.Domain;
using Yibai.Api.Request;
using Yibai.Api.Response;
using Yibai.Api.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api
{
    /*
     * Yibai 客户端
     */
    public class DefaultYibaiClient : YibaiClient
    {
        private string serveUrl;

        private string apikey;

        public DefaultYibaiClient(string serverUrl, string apikey)
        {
            this.serveUrl = serverUrl;
            this.apikey = apikey;
        }

        public List<SmsBatchSubmitResult> SmsBatchSubmit(List<SmsSubmit> submits)
        {
            SmsBatchSubmitRequest request = new SmsBatchSubmitRequest();
            request.submits = submits;
            return execute<SmsBatchSubmitResponse, List<SmsBatchSubmitResult>>(request);
        }

        public List<SmsStatusReport> SmsPullStatusReport()
        {
            SmsPullStatusReportRequest request = new SmsPullStatusReportRequest();
            return execute<SmsPullStatusReportResponse, List<SmsStatusReport>>(request);
        }

        public List<SmsReplyMessage> SmsPullReplyMessage()
        {
            SmsPullReplyMessageRequest request = new SmsPullReplyMessageRequest();
            return execute<SmsPullReplyMessageResponse, List<SmsReplyMessage>>(request);
        }

        public UserInfo UserInfo()
        {
            UserInfoRequest request = new UserInfoRequest();
            return execute<UserInfoResponse, UserInfo>(request);
        }

        protected R execute<T, R>(YibaiRequest<T> request) where T : YibaiResponse<R>
        {
            request.apikey = apikey;
            string reqJson = JsonConvert.SerializeObject(request);
            string reqUrl = serveUrl + request.GetApiUrlPath();
            string resJson = HttpUtils.PostJson(reqUrl, reqJson);

            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resJson)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(request.GetResponseType());
                T res = (T)serializer.ReadObject(ms);
                if (res.IsSuccess())
                {
                    return res.response;
                }
                throw new YibaiApiException(res.code, res.message);
            }
        }
    }
}
