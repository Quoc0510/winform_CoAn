using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.DAO_Layer
{
   public class TimeKeepingDAO
    {
        private static TimeKeepingDAO instance;

        public static TimeKeepingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TimeKeepingDAO();
                return TimeKeepingDAO.instance;
            }
            private set { TimeKeepingDAO.instance = value; }
        }

        private TimeKeepingDAO() { }

        public DataTable GetAll()
        {
            string sql = "select * from TimeKeeping";
            return DataProviderDAO.Instance.Select(sql, false);
        }
    }
}

