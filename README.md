# 亿佰云通讯 sdk

---

 - 添加maven依赖
 
```xml
<dependency>
    <groupId>com.github.100sms</groupId>
    <artifactId>yibai-sms-java-sdk</artifactId>
    <version>1.0.0</version>
</dependency>
```
*如果非maven项目可手动<a target="_blank" href="http://search.maven.org/#search%7Cga%7C1%7Ccom.github.100sms">获取jar包</a>*

 - 调用方法
 
```Java
 private static final String serverUrl = "https://sms.100sms.cn/api";
 private static final String apikey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";//修改为您的apikey
 private static final YibaiClient client = new DefaultYibaiClient(serverUrl, apikey);

 public void testSmsBatchSubmit() {
     try {
         client.smsBatchSubmit(Arrays.asList(
             new SmsSubmit("187xxxxxxxx", "【亿佰云通讯】您的验证码是：1234"),//修改为你要发送的手机号和短信内容
             new SmsSubmit("186xxxxxxxx", "【亿佰云通讯】您的验证码是：5678")//修改为你要发送的手机号和短信内容
         ));
     } catch (YibaiApiException e) {
         System.out.println("YibaiApiException, code: " + e.getCode() + ", message: " + e.getMessage());
     } catch (Exception e) {
         e.printStackTrace();
     }
 }

```

# 注意事项

 - 请使用jdk1.7或更高版本
 - 测试sdk请使用YibaiClientTest类,http请求测试请使用JavaSmsApiSample类
 - 详细api文档请参考<a target="_blank" href="https://web.100sms.cn/api1.0/document">https://web.100sms.cn/api1.0/document</a>
