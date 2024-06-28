using Kivii.Server;
using Kivii.Logging;
using Kivii;
using Kivii.Server.Http;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.LogFactory = new ConsoleLogFactory(true);
            SelfHost host = new SelfHost();
            if (args.Length > 0)
            { host.Start(args[0]); }
            else
            { host.Start(); }
            //增加异常类型，对应的错误代码
            //HostConfig.Instance.MapExceptionToStatusCode.Add();
            //允许下载的文件类型
            HostConfig.Instance.AllowFileExtensions.Add("json");
            //登陆界面
            KiviiContext.IndexPage = "/login";
            //模拟登陆用户
            System.Console.ReadLine();
        }
    }
}
