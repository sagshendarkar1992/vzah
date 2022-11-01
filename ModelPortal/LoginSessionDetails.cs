using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPortal
{
    public struct LoginSessionDetails
    {
        public int RollId;
        public int ModuleId;
        public int UserId;
        public string LoginName;
        public int MainMenuID;
        public int SYSDOCID;
        public int SLID;
        public int USERTYPE;
        public string UserTime;
        public DateTime time;
        public string Timezone;
        public string GMTdiffrence { get; set; }
        public int GMThours { get; set; }
        public int GMTminutes { get; set; }
        public string IMGPATH { get; set; }
    }
}
