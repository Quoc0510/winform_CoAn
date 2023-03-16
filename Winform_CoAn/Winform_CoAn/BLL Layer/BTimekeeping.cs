using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.BLL_Layer
{
    public class BTimekeeping
    {
        public DateTime Time { get; set; }
        public ETimekeepingStatus Status;
        public string IDEmployee;
    }

    public enum ETimekeepingStatus
    {
        Active,
        Inactive,
    }
}
