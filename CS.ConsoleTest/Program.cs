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

            ServiceLoader.LoadService(@"E:\gitproject\ServiceContainer\CS.MsgServiceDemo\bin\Debug\CS.MsgServiceDemo.dll");

            //ServiceLoader.LoadService();

            var service = ServiceLoader.ResolveService();

            executeService(service);

            Console.ReadLine();

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
