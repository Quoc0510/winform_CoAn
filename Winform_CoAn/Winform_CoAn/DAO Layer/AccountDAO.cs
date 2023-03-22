using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_CoAn.DAO_Layer;

using Winform_CoAn.DTO;

namespace Winform_CoAn.DAO_Layer
{

    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public int GetByAccount(Account tk)
        {
            string sql = "select UserName, PassWord from Account where UserName=@UserName and PassWord=@PassWord";
            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@UserName", tk.UserName);
            para.Add("@PassWord", tk.PassWord);

            DataTable dt = DataProviderDAO.Instance.Select(sql, false, para);

            List<Account> lsAcc = new List<Account>();
            foreach (DataRow row in dt.Rows)
            {
                lsAcc.Add(new Account(row));
            }
            return lsAcc.Count;
        }
    }
}