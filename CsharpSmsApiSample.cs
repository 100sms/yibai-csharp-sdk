using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
/*
* 说明:
* 以下代码展示的是非sdk下的调用，只是为了方便用户测试而提供的样例代码，用户也可自行编写。
* 正式环境建议使用sdk进行调用以提高效率，sdk中包含了使用样例
*/
namespace ShomopSdkTest
{
    class Program
    {

        static void Main(string[] args)
        {
            string json = ("{" +
                "  'apikey':'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx'," + // 修改为您的apikey
                "  'submits':[{" +
                "    'mobile':'132xxxxxxxx'," +  // 修改为您要发送的手机号
                "    'message':'【亿佰云通讯】您的验证码是：1234'" + // 修改为您要发送的内容，内容必须和某个模板匹配
                "  }]" +
                "}"
            ).Replace('\'', '"');
            Console.WriteLine(PostCURL("https://sms.100sms.cn/api/sms/batchSubmit", json));
        }

        public static string PostCURL(string url, string postData)
        {

            byte[] dataArray = Encoding.UTF8.GetBytes(postData);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = dataArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(dataArray, 0, dataArray.Length);
            dataStream.Close();
            StreamReader reader = null;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                String res = reader.ReadToEnd();

                return res;
            }
            catch (SystemException e)
            {
                return (e.Message + e.ToString());
            }
            finally
            {
                reader.Close();
            }


        }
    }
}
