using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.BasicInterface;

namespace CS.MsgServiceDemoDAL
{
    public class User
    {

        private IDbHelper _dbHelper;

        public User(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public String GetUserName(Int32 id)
        {

            var list = _dbHelper.ExecuteSql<String>("sql");

            return "test";
        }


    }
}
