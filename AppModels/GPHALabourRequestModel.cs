using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class GPHALabourRequestModel
    {
        [JsonProperty("RequestDetails")]
        public List<Request> RequestDetails { get; set; }
        public int TotalRecords { get; set; }
    }
    public class Request
    {
        [JsonProperty("Request Date")]
        public DateTime RequestDate
        {
            get;
            set;
        }
        [JsonProperty("Labour Request ID")]
        public string LabourRequestID
        {
            get;
            set;
        }
        [JsonProperty("Unit Description")]
        public string UnitDescription
        {
            get;
            set;
        }
        [JsonProperty("Job Requested")]
        public string JobRequested
        {
            get;
            set;
        }
        [JsonProperty("Number Requested")]
        public string NumberRequested
        {
            get;
            set;
        }
        [JsonProperty("Needed On")]
        public string NeededOn
        {
            get;
            set;
        }
    }
}
