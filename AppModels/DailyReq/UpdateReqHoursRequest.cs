using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class UpdateReqHoursRequest
    {
        public double Normal { get; set; }
        public double Overtime { get; set; }
        public string Hourby { get; set; }
        public DateTime HourDate { get; set; } = DateTime.Now;
        public string ReqNo { get; set; }
    }
}
