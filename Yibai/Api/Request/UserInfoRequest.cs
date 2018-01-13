using Yibai.Api.Common;
using Yibai.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Request
{
    public class UserInfoRequest : YibaiRequest<UserInfoResponse>
    {
        public override string GetApiUrlPath()
        {
            return "/user/get";
        }
        public override Type GetResponseType()
        {
            return typeof(UserInfoResponse);
        }
    }
}
