using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class LabourRequest
    {
        public Guid Id { get; set; }
        public DateTime RequestDate { get; set; }
        public string? LabourRequestId { get; set; }
        public string? UnitDescription { get; set; }
        public string? JobDescription { get; set; }
        public int NumberRequested { get; set; }
        public DateTime NeededOn { get; set; }
        public string? RequestId { get; set; }
    }
}
