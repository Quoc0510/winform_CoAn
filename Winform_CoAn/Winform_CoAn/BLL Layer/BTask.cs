using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.BLL_Layer
{
    public class BTask
    {
        public BTask() { }
        public string ID;
        public string Name;
        public EStatus Status;
        public string IDProject;
        public string IDEmployee;

    }

    public enum EStatus
    {
        New,
        Assigned,
        Resolved,
        Feedback,
        Closed,
        Rejected
    }
}
