using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class PayrollProcessRequest
    {
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
        public string processedby { get; set; }
    }
}
