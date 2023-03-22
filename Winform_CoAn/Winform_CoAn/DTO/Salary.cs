using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.DTO
{
    public class Salary
    {
        public string ID { get; set; }
        public string EmployeeName { get; set; }
        public float SalaryCount { get; set; }
        public float BonusSalary { get; set;}
        public Salary() { }
        public Salary(DataRow row)
        {
            ID = row["ID"].ToString();
            EmployeeName = row["Name"].ToString();
            SalaryCount = float.Parse(row["SalaryCount"].ToString());
            BonusSalary = float.Parse(row["BonusSalary"].ToString());
        }
    }
}
