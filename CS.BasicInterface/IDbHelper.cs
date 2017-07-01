using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BasicInterface
{
    public interface IDbHelper
    {
        List<T> ExecuteSql<T>(String sql);
    }
}
