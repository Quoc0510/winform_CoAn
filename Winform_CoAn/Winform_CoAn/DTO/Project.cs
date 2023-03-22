using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_CoAn.BLL_Layer;

namespace Winform_CoAn.DTO
{
    internal class Project
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Status { get; set; }
            
        public Project() { }

        public Project(DataRow row)
        {
            ID = row["ID"].ToString();
            Name = row["Name"].ToString();
            Manager = row["Manager"].ToString();
            Status = row["Status"].ToString();
           
        }
    }
}
