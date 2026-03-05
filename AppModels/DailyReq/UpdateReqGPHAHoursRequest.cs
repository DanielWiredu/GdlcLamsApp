using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class UpdateReqGPHAHoursRequest
    {
        public double Normal { get; set; }
        public double Overtime { get; set; }
        public string GPHA_RequestID { get; set; }
        public string ReqNo { get; set; }
    }
}
