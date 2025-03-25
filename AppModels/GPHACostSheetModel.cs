using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class GPHACostSheetModel
    {
        [JsonProperty("RequestDetails")]
        public List<CostSheet> RequestDetails { get; set; }
    }

    public class CostSheet
    {
        [JsonProperty("Labour Request ID")]
        public string LabourRequestID
        {
            get;
            set;
        }
        [JsonProperty("Worker")]
        public string Worker
        {
            get;
            set;
        }
        [JsonProperty("Hours Worked")]
        public double HoursWorked
        {
            get;
            set;
        } = 0;
        [JsonProperty("Overtime Hours")]
        public string OvertimeHours
        {
            get;
            set;
        } = "0";
    }
}
