using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.BasicInterface;

namespace BasicConsoleComponent
{
    public class ConsoleLogger : ILogger
    {
        public void Error(string msg, Exception ex = null)
        {
            Console.WriteLine("Error:" + msg);
        }

        public void Info(string msg)
        {
            Console.WriteLine("Info:" + msg);
        }

        public void Log(string msg)
        {
            Console.WriteLine("Log:" + msg);
        }

        public void Warn(string msg)
        {
            Console.WriteLine("Warn:" + msg);
        }
    }
}
