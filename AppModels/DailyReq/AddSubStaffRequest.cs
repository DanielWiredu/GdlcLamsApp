using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class AddSubStaffRequest
    {
        public string ReqNo { get; set; } = string.Empty;
        public string WorkerId { get; set; } = string.Empty;
        public int? TradegroupID { get; set; }
        public string transport { get; set; } = string.Empty;
        public int? TradetypeID { get; set; }
    }
}
