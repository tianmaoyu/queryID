using DotNet.Utilities;
using Fiddler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace IDQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
            FiddlerApplication.Startup(8888, FiddlerCoreStartupFlags.CaptureLocalhostTraffic | FiddlerCoreStartupFlags.RegisterAsSystemProxy);
            this.tb_cpu.Text = GetUPU();
            this.tb_key.Text = ReadKeyFormFile();
        }

        private void FiddlerApplication_BeforeRequest(Session oSession)
        {
            if (this.checkBox_UpdataCookie.Checked)
            {
                if (oSession.fullUrl.Contains("www.baidu.com"))
                {
                    var headers = oSession.oRequest.headers.ToString();
                    if (headers.Contains("Cookie:"))
                    {
                        var cookieIndex = headers.IndexOf("Cookie") + 8;
                        var cookieValue = headers.Substring(cookieIndex);
                        if (cookieValue.Length > 40)
                        {
                            WriteCookie(cookieValue);
                        }
                    }
                }
            }
        }

        public String GetUPU()
        {
            string reslut = null;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                reslut = mo.Properties["ProcessorId"].Value.ToString();
                break;
                //break;
            }
            return reslut.Trim();
        }
        public string ReadKeyFormFile()
        {
            string reslut = null;
                using (FileStream file = new FileStream("D:\\IDkey.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                file.Close();
                }
            using (StreamReader sr = new StreamReader("D:\\IDkey.txt"))
            {
                reslut = sr.ReadToEnd().Trim();
                sr.Close();
             }
            return reslut;
        }
        public void WriteKeyToFile(string key)
        {
            if (key == "") return;
            using (FileStream file = new FileStream("D:\\IDkey.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                file.Close();
            }
            if (ReadKeyFormFile().Length < 3)
            {
                using (StreamWriter sw = new StreamWriter("D:\\IDkey.txt"))
                {
                    sw.WriteLine(key);
                    sw.Close();
                }
            }
        }
        public string ReadKeyFormCoockieFile()
        {
            string reslut = null;
            using (FileStream file = new FileStream("D:\\IDcoockie.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                file.Close();
            }
            using (StreamReader sr = new StreamReader("D:\\IDcoockie.txt"))
            {
                reslut = sr.ReadToEnd().Trim();
                sr.Close();
            }
            return reslut;
        }

        public void WriteCookie(string cookie)
        {
            if (cookie == "") return;
            using (FileStream file = new FileStream("D:\\IDcoockie.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                file.Close();
            }
          
                using (StreamWriter sw = new StreamWriter("D:\\IDcoockie.txt",false))
                {
                    sw.WriteLine(cookie);
                    sw.Close();
                }
           
        }
        private void button_seach_Click(object sender, EventArgs e)
        {
            this.checkBox_UpdataCookie.Checked = false;
            //var time = Convert.(1472471790952);
             string coockie = ReadKeyFormCoockieFile();
            string cpu = GetUPU();
            var byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(cpu).ToArray();
            string keys = null;
            foreach(var k in byKey)
            {
                keys += k.ToString();
            }
            WriteKeyToFile(this.tb_key.Text.Trim());
            if (!this.tb_key.Text.Trim().Equals(keys))
            {
                MessageBox.Show("输入授权码或者授权码不正确！");
                return;
            }
            var time =  DateTime.Now.ToFileTimeUtc();
            //var t = Int64.Parse(time);
           // var coockieTime= ((t - (70 * 365) - 19) * 86400 - (8 * 3600)).ToString();
            HttpHelper http = new HttpHelper();
            ServicePointManager.DefaultConnectionLimit = 1000;
            string number = this.tb_phoneNumber.Text.Trim();
          
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
                Cookie = coockie,
                //Cookie = "CCSSESSIONID=62424096b966e0616bc3d17398ec.ccs-web-g1-srv13; ccs1=kf-crm-web13; AIPortal_Oper_LastAccessedTime=MTQ3MjQ3MTc5MDk1Mg==; AIPortal_Oper_ActiveUrl=aHR0cDovL3Nzb3dlYi5jcm0uZ3ouY21jYw==; AIPortal_HostIp=MTM1LjEwLjUyLjM3; AIPortal_Port=MTAxMjE=; AIPortal_SessionId=1y5f5hwxcxrqgfio25xx9vjhqn1b24js; AIPortal_Oper_OpId=NTkwMDY0NzY=; AIPortal_Oper_OrgId=NTkwMDE2MzE=; AIPortal_Oper_OpName=vPLF9A==; AIPortal_Oper_LogName=NTkwMDY0NzY=; AIPortal_Oper_HostIp=MTM5LjExLjAuMTA3; AIPortal_Result=dHJ1ZQ==; AIPortal_Context_Path=; AIPortal_MAC=; AIPortal_CNAME=; AIPortal_4A_Session_Id=MTQ3MjQ3MTc5MDgzMQ==; AIPortal_Region_Id=ODU5; AIPortal_Res_Id=MTE5MDAy; AIPortal_Station_Id=; cname=; mac=",//字符串Cookie     可选项
                //Cookie = "AIPortal_Oper_LastAccessedTime=MTQ3MTQzMjQxNDA1Nw==; AIPortal_Oper_ActiveUrl=aHR0cDovL3Nzb3dlYi5jcm0uZ3ouY21jYw==; AIPortal_HostIp=MTM1LjEwLjUyLjM3; AIPortal_Port=MTAxMjY=; AIPortal_SessionId=15flag1s1yoe0uuj1vn5szgj24ro1z55; AIPortal_Oper_OpId=NTkwMDY0NzY=; AIPortal_Oper_OrgId=NTkwMDE2MzE=; AIPortal_Oper_OpName=vPLF9A==; AIPortal_Oper_LogName=NTkwMDY0NzY=; AIPortal_Oper_HostIp=MTM5LjExLjIuMjM=; AIPortal_Result=dHJ1ZQ==; AIPortal_Context_Path=; AIPortal_MAC=; AIPortal_CNAME=; AIPortal_4A_Session_Id=MTQ3MTQzMjQxMzkyMA==; AIPortal_Region_Id=ODU5; AIPortal_Res_Id=MTE5MDAy; AIPortal_Station_Id=; cname=; mac=; CCSSESSIONID=834e9972bb232056d91affaafa29.ccs-web-g1-srv14; ccs1=kf-crm-web32",//字符串Cookie     可选项
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
            //CUST_CERT_CODE
            Regex regID = new Regex(@"CUST_CERT_CODE[^<]*");
            Match matchID = regID.Match(html);
            if (matchID.Value != null)
            {
               var id= matchID.Value.Substring(matchID.Value.IndexOf('>')+1);
                this.tb_Identification.Text = id;
            }
            //CUST_NAME
            Regex regName = new Regex(@"CUST_NAME[^<]*");
            Match matchName = regName.Match(html);
            if (matchName.Value != null)
            {
                var name = matchName.Value.Substring(matchName.Value.IndexOf('>')+1);
                this.tb_name.Text = name;
            }
            //CONT_CERT_ADDRESS
            Regex regAddress = new Regex(@"CONT_CERT_ADDRESS[^<]*");
            Match matchAddress = regAddress.Match(html);
            if (matchAddress.Value != null)
            {
                var adress = matchAddress.Value.Substring(matchAddress.Value.IndexOf('>')+1);
                this.tb_adress.Text = adress;
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FiddlerApplication.Shutdown();
        }
    }
}
