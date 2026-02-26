using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class DisapproveReqRequest
    {
        public bool Processed { get; set; }
        public string ReqNo { get; set; }
        public string DisApprovedBy { get; set; }
    }
}
