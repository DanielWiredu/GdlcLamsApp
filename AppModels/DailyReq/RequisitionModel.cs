using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class RequisitionModel
    {
        public string? AutoNo { get; set; }
        public string? RequestNo { get; set; }

        public int? CompanyId { get; set; }
        public int? VesselId { get; set; }
        public int? ReportingPointId { get; set; }
        public int? LocationId { get; set; }

        public DateTime? RequisitionDate { get; set; }

        public int? CargoId { get; set; }
        public int? GangId { get; set; }

        public string? JobDescription { get; set; }
        public string? GphaRequestId { get; set; }

        public TimeSpan? NormalFrom { get; set; }
        public TimeSpan? NormalTo { get; set; }

        public TimeSpan? OvertimeFrom { get; set; }
        public TimeSpan? OvertimeTo { get; set; }

        public bool ShipSide { get; set; }
        public bool Weekend { get; set; }
        public bool Night { get; set; }

        public string? ShiftType { get; set; } = "Non-Shift";

        public double NormalHours { get; set; }
        public double OvertimeHours { get; set; }
    }

}
