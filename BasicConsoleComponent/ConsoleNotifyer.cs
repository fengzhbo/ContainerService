using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.BasicInterface;

namespace BasicConsoleComponent
{
    public class ConsoleNotifyer : INotifyer
    {
        public void Notify(string msg)
        {
            Console.WriteLine("通知：" + msg);
        }
    }
}
