using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Winform_CoAn.DTO
{
    public class Role
    {
        public string ID { get; set; }
        public string RoleName { get; set; }

        public Role() { }
        public Role (DataRow row)
        {
            ID = row["ID"].ToString();
            RoleName = row["RoleName"].ToString();
        }
    }
}
