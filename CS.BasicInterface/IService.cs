using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BasicInterface
{
    public interface IService : IDisposable
    {
        void ExcuteMsg(String msg);
    }

}
