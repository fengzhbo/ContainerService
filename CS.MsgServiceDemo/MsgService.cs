using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.BasicInterface;

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

        public MsgService(IDbHelper dbHelper, ILogger logger, INotifyer notifyer)
        {
            _dbHelper = dbHelper;
            _logger = logger;
            _notifyer = notifyer;
        }


        public void ExcuteMsg(string msg)
        {
            _logger.Info("Receive msg:" + msg);

            var data = _dbHelper.ExecuteSql<String>("select * from table");

            _notifyer.Notify("通知：" + msg);


        }
    }
}
