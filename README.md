# 亿佰云通讯 sdk

---

 - 运行方法
 
```
1.在vs中新建控制台程序，将该sdk源码复制到新建的控制台程序中；

2.在项目中引用Newtonsoft.Json.dll、System.Runtime.Serialization；

3.在控制台程序的main方法中即可运行测试该sdk，具体测试方法参照该目录下CsharpClientTest.cs文件。
```

 - 打包方法
 
```

1.在vs中新建类库项目；

2.将sdk源码复制到新建的类库项目中；

3.在新建的类库项目中引用Newtonsoft.Json.dll、System.Runtime.Serialization；

4.右键项目，点击生成，vs显示生成成功后，在项目的Debug目录中出现已生成的sdk的dll文件
```

# 注意事项
 - CsharpSmsApiSample.cs为非sdk调用示例,sdk调用请参考CsharpClientTest.cs方法.
 - 详细api文档请参考https://www.100sms.cn/api1.0/document
