using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BasicConsoleComponent;
using CS.BasicInterface;

namespace CS.ServiceMananger
{
    public class ServiceLoader
    {
        private static ContainerBuilder IocBuilder = null;

        private static IContainer iocContainer = null;

        public static void LoadService(String path)
        {
            //var ad = AppDomain.CreateDomain("ServiceDemo", null, null);

            //ad.CreateComInstanceFrom(@"C:\Users\fengzhbo\Documents\GitHubVisualStudio\ContainerService\ContainerService\load", "");

            ////var assembly =
            //    Assembly.LoadFrom(
            //        @"C:\Users\fengzhbo\Documents\GitHubVisualStudio\ContainerService\ContainerService\CS.MsgServiceDemo\bin\Debug\CS.MsgServiceDemo.dll");

            IocBuilder = IocBuilder ?? new ContainerBuilder();

            var assembly = Assembly.LoadFrom(path);

            IocBuilder.RegisterAssemblyTypes(assembly)
                //.Where(t => t.IsAssignableFrom(typeof(IService)))
                .Where(t => t.Name.EndsWith("Service"))
               // .Named<IService>("")
                .As<IService>();

            iocContainer = IocBuilder.Build();
        }

        public static void LoadService()
        {
            //var ad = AppDomain.CreateDomain("ServiceDemo", null, null);

            //ad.CreateComInstanceFrom(@"C:\Users\fengzhbo\Documents\GitHubVisualStudio\ContainerService\ContainerService\load", "");

            ////var assembly =
            //    Assembly.LoadFrom(
            //        @"C:\Users\fengzhbo\Documents\GitHubVisualStudio\ContainerService\ContainerService\CS.MsgServiceDemo\bin\Debug\CS.MsgServiceDemo.dll");

            IocBuilder = IocBuilder ?? new ContainerBuilder();

            var assembly = AppDomain.CurrentDomain.GetAssemblies();

            IocBuilder.RegisterAssemblyTypes()
                .Where(t => t.IsSubclassOf(typeof(IService)))
                //.Where(t => t.Name.EndsWith("Service"))
                // .Named<IService>("")
                .As<IService>();

            iocContainer = IocBuilder.Build();
        }

        static ServiceLoader()
        {
            IocBuilder = new ContainerBuilder();

            IocBuilder.RegisterType<ConsoleLogger>().As<ILogger>();
            IocBuilder.RegisterType<ConsoleDbHelper>().As<IDbHelper>();
            IocBuilder.RegisterType<ConsoleNotifyer>().As<INotifyer>();

            //iocContainer = IocBuilder.Build();
        }

        public static IService ResolveService()
        {
            return iocContainer.IsRegistered<IService>() ? iocContainer.Resolve<IService>() : null;
        }

    }
}
