using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class VmApprovedGPHARequest
    {
        public string LabourRequestId { get; set; } = null!;
        public DateTime? RequestDate { get; set; }
        public string? UnitDescription { get; set; }
        public string? JobRequested { get; set; }
        public string? NumberRequested { get; set; }
        public DateTime? RNeededOn { get; set; }
        public string? RDay { get; set; }
        public string? RShift { get; set; }
        public string? CostSheetNo { get; set; }
        public DateTime? PreparedOn { get; set; }
        public bool GphaApproved { get; set; }
        public DateTime? GphaApprovedDate { get; set; }
        public bool GdlcApproved { get; set; }
        public DateTime? GdlcApprovedDate { get; set; }
        public bool HasCostSheet { get; set; }
    }
}
