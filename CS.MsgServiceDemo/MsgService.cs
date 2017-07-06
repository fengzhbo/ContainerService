using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.BasicInterface;
using CS.MsgServiceDemo.Common;
using CS.MsgServiceDemoDAL;

namespace CS.MsgServiceDemo
{
    public class MsgService : IService
    {
        public void Dispose()
        {

        }


        private IDbHelper _dbHelper;
        private ILogger _logger;
        private INotifyer _notifyer;

        private User _userDal;

        public MsgService(IDbHelper dbHelper, ILogger logger, INotifyer notifyer)
        {
            _dbHelper = dbHelper;
            _logger = logger;
            _notifyer = notifyer;

            _userDal = new User(dbHelper);
        }


        public void ExcuteMsg(string msg)
        {
            _logger.Info("Receive msg:" + msg);

            String sql = StringUtil.SqlTrim("select * from table   ");

            var data = _userDal.GetUserName(1);

            _notifyer.Notify("通知：" + sql + data);


        }
    }
}
