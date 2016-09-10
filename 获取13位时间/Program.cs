using System;
using System.Text;


namespace 获取13位时间
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now.ToFileTimeUtc().ToString();
            time= time.Substring(0, 13);
            Console.Write("时间为：");
            Console.WriteLine(time);
            Console.Write("编码后为：");
            byte[] bytes = Encoding.Default.GetBytes(time);
            string str = Convert.ToBase64String(bytes);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
