using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BasicInterface
{
    public interface ILogger
    {
        void Log(String msg);

        void Warn(String msg);

        void Info(String msg);

        void Error(String msg, Exception ex = null);

    }

}
