using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.BLL_Layer
{
    public class BProject
    {
        public BProject() { }
        public string ID;
        public string Name;
        public DateTime Date;
        public EStatus Status;
        public BEmployee Owner;
        public List<BTask> Tasks;
    }
}
