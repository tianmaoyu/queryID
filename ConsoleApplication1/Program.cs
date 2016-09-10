using DotNet.Utilities;
using System;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpHelper http = new HttpHelper();
            ServicePointManager.DefaultConnectionLimit = 1000;
            Console.WriteLine("请输入电话号码：");
            string number = Console.ReadLine();
            //http://cs.crm.gz.cmcc/business/com.ai.oneframe.info.web.CustInfoItemAction?action=queryCustomer&queryNum=18748885888&url_source=XMLHTTP HTTP/1.1
            String url = "http://cs.crm.gz.cmcc/business/com.ai.oneframe.info.web.CustInfoItemAction?action=queryCustomer&queryNum=" + number + "&url_source=XMLHTTP";
            HttpItem item = new HttpItem()
            {
                URL = url,//URL     必需项
                Encoding = null,//编码格式（utf-8,gb2312,gbk）     可选项 默认类会自动识别
                Method = "GET",//URL     可选项 默认为Get
                Timeout = 250000,//连接超时时间     可选项默认为100000
                ReadWriteTimeout = 30000,//写入Post返回结果超时时间     可选项默认为30000
                KeepAlive = true,
                ProtocolVersion = HttpVersion.Version11,
                IsToLower = false,//得到的HTML代码是否转成小写     可选项默认转小写
                Cookie = "CCSSESSIONID=62424096b966e0616bc3d17398ec.ccs-web-g1-srv13; ccs1=kf-crm-web13; AIPortal_Oper_LastAccessedTime=MTQ3MjgxNjQxMDA3MQ==; AIPortal_Oper_ActiveUrl=aHR0cDovL3Nzb3dlYi5jcm0uZ3ouY21jYw==; AIPortal_HostIp=MTM1LjEwLjUyLjM3; AIPortal_Port=MTAxMjE=; AIPortal_SessionId=1y5f5hwxcxrqgfio25xx9vjhqn1b24js; AIPortal_Oper_OpId=NTkwMDY0NzY=; AIPortal_Oper_OrgId=NTkwMDE2MzE=; AIPortal_Oper_OpName=vPLF9A==; AIPortal_Oper_LogName=NTkwMDY0NzY=; AIPortal_Oper_HostIp=MTM5LjExLjAuMTA3; AIPortal_Result=dHJ1ZQ==; AIPortal_Context_Path=; AIPortal_MAC=; AIPortal_CNAME=; AIPortal_4A_Session_Id=MTQ3MjQ3MTc5MDgzMQ==; AIPortal_Region_Id=ODU5; AIPortal_Res_Id=MTE5MDAy; AIPortal_Station_Id=; cname=; mac=",//字符串Cookie     可选项
                UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; .NET4.0E)",//用户的浏览器类型，版本，操作系统     可选项有默认值
                //Accept = "text/html, application/xhtml+xml, */*",//    可选项有默认值
                ContentType = "text/html",//返回类型    可选项有默认值
                Referer = "http://cs.crm.gz.cmcc/webframe/info/customer.jsp",//来源URL     可选项
                //CerPath = "taobao.cer",
                ResultType = ResultType.Byte,
                //Allowautoredirect = true,//是否根据３０１跳转     可选项
                Connectionlimit = 1024,//最大连接数     可选项 默认为1024
                //ProxyIp = ip,//代理服务器ID 端口可以直接加到后面以：分开就行了    可选项 不需要代理 时可以不设置这三个参数
                             // ResultType = ResultType.String,//返回返回结果类型，是Byte还是String
                CookieCollection = new System.Net.CookieCollection(),//可以直接传一个Cookie集合进来
                
            };
            HttpResult result = http.GetHtml(item);
            //取出返回的Cookie
            string cookie = result.Cookie;
            //返回的Html内容
            string html = result.Html;
            Console.WriteLine("返回的结果如下：");
            Console.WriteLine(html);
            Console.ReadKey();
        }
    }
}
