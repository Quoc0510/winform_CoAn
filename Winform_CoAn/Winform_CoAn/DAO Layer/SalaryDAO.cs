using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.DAO_Layer
{
    class SalaryDAO
    {
        private static SalaryDAO instance;

        public static SalaryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SalaryDAO();
                return SalaryDAO.instance;
            }
            private set { SalaryDAO.instance = value; }
        }

        private SalaryDAO() { }

        public DataTable GetAll()
        {
            string sql = "select * from Salary";
            return DataProviderDAO.Instance.Select(sql, false);
        }
    }
}
