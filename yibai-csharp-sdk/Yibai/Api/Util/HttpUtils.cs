using Yibai.Api.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yibai.Api.Util
{
    public class HttpUtils
    {
        public static string PostJson(string url, string json)
        {

            byte[] dataArray = Encoding.UTF8.GetBytes(json);

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

                if ((int)response.StatusCode != 200)
                {
                    throw new YibaiException();
                }
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
