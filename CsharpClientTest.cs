using Newtonsoft.Json;
using Yibai.Api;
using Yibai.Api.Common;
using Yibai.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yibai
{
    class Program
    {
        private const String serverUrl = "xxxxxxxxx";//修改为相应的api地址
        private const String apikey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";//修改为您的apikey
        public static YibaiClient client = new DefaultYibaiClient(serverUrl, apikey);

        static void Main(string[] args)
        {
            TestSmsBatchSubmit();
            Console.ReadLine();
            TestSmsPullStatusReport();
            Console.ReadLine();
            TestSmsPullReplyMessage();
            Console.ReadLine();
        }
        public static void TestSmsBatchSubmit()
        {
            try
            {
                List<SmsSubmit> smsSubmits = new List<SmsSubmit>();
                SmsSubmit smsSubmit1 = new SmsSubmit("176xxxxxxxx", "【亿佰云通讯】您的验证码是：1234");
                SmsSubmit smsSubmit2 = new SmsSubmit("136xxxxxxxx", "【亿佰云通讯】您的验证码是：5678");
                smsSubmits.Add(smsSubmit1);
                smsSubmits.Add(smsSubmit2);

                Console.WriteLine(JsonConvert.SerializeObject(client.SmsBatchSubmit(smsSubmits)));
            }
            catch (YibaiApiException e)
            {
                Console.WriteLine("YibaiApiException, code: " + e.code + ", message: " + e.message);
            }
            catch(Exception e){
                e.ToString();
            }
            
        }

        public static void TestSmsPullStatusReport()
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(client.SmsPullStatusReport()));
            }
            catch (YibaiApiException e)
            {
                Console.WriteLine("YibaiApiException, code: " + e.code + ", message: " + e.message);
            }
            catch(Exception e){
                e.ToString();
            }
            
        }

        public static void TestSmsPullReplyMessage()
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(client.SmsPullReplyMessage()));
            }
            catch (YibaiApiException e)
            {
                Console.WriteLine("YibaiApiException, code: " + e.code + ", message: " + e.message);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
    }
}
