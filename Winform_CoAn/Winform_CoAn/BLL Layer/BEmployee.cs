using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_CoAn.BLL_Layer
{
    public class BEmployee : BHuman
    {
        public BEmployee() { }

        public EPosition Position;
        public BAccount Account;
        public int Cast;
    }

    public enum EPosition
    {
        Member,
        Leader
    }

    public class BAccount
    {
        public BAccount() { }
        public string Username;
        public string Password;

    }
}
