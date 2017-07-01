using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CS.BasicInterface;

namespace BasicConsoleComponent
{
    public class ConsoleDbHelper : IDbHelper
    {
        public List<T> ExecuteSql<T>(string sql)
        {
            Console.WriteLine("执行数据操作:" + sql);

            return new List<T>();
        }
    }
}
