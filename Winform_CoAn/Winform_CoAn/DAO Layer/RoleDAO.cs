using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.DAO_Layer
{
    class RoleDAO
    {
  
        private static RoleDAO instance;
        public static RoleDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleDAO();
                return RoleDAO.instance;
            }
            private set { RoleDAO.instance = value; }
        }
        private RoleDAO() { }

        public DataTable GetAll()
        {
            string sql = "select * from UserRole ";
            return DataProviderDAO.Instance.Select(sql, false);
        }

        public DataTable GetById(string id)
        {
            string sql = "select * from UserRole where ma like @id";
            Dictionary<string, object> para = new Dictionary<string, object>();

            return DataProviderDAO.Instance.Select(sql, false, para);
        }
    }
}
