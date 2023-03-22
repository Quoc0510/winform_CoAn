using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Winform_CoAn.DTO
{
    public class Account
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public Account() { }

        public Account(DataRow row)
        {
            UserName = row["UserName"].ToString();
            PassWord = row["PassWord"].ToString();
        }

        public Account (string _userName, string _passWord)
        {
            this.UserName = _userName;
            this.PassWord = _passWord;
        }
    }
}
