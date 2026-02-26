using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class ApproveReqRequest
    {
        public DateTime Adate { get; set; }
        public string ApprovedBy { get; set; }
        public string ReqNo { get; set; }
    }
}
