using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Winform_CoAn.DTO
{
    public class Human
    { 
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Account { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }
        public float Salary { get; set; }

        public Human() { }

        public Human(DataRow row)
        {
            ID      = row["id"].ToString();
            Name    = row["name"].ToString();
            Address = row["address"].ToString();
            Account = row["account"].ToString();
            PassWord = row["password"].ToString();
            Role = row["role"].ToString();
            Salary  = float.Parse(row["salary"].ToString());
        }
    }
}
