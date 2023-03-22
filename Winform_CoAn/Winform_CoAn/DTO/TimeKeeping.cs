using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.DTO
{
    public class TimeKeeping
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime Timekeeping { get; set; }

        public string CountDayKeeping { get; set; }

        public TimeKeeping() { }
        public TimeKeeping(DataRow row)
        {
            ID = row["ID"].ToString();
            Name = row["Name"].ToString();
            Status = row["Status"].ToString();
            Timekeeping = DateTime.Parse(row["Timekeeping"].ToString());
            CountDayKeeping = row["CountDayKeeping"].ToString();
        }

    }
}
