using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.BasicInterface;
using CS.ServiceMananger;

namespace CS.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLoader.InitService();


            var service = ServiceLoader.ResolveService();

            executeService(service);

            ServiceLoader.LoadService(@"C:\Users\fengzhbo\Documents\GitHubVisualStudio\ContainerService\ContainerService\CS.MsgServiceDemo\bin\Debug\CS.MsgServiceDemo.dll");

            service = ServiceLoader.ResolveService();

            executeService(service);

        }

        private static void executeService(IService service)
        {
            if (service!=null)
            {
                Console.WriteLine("开始执行服务");
                service.ExcuteMsg("test msg");
            }
            else
            {
                Console.WriteLine("没有合适的服务");
            }


        }

    }
}
