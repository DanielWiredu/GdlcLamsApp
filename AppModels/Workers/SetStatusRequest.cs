using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.Workers
{
    public class SetStatusRequest
    {
        public string WorkerID { get; set; }
        public string Flag { get; set; }
    }
}
