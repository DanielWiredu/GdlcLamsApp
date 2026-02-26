using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DailyReq
{
    public class RequisitionModel
    {
        public int AutoNo { get; set; }
        public string? RequestNo { get; set; }

        public int CompanyId { get; set; } = 0;
        public int VesselId { get; set; } = 0;
        public int ReportingPointId { get; set; } = 0;
        public int LocationId { get; set; } = 0;

        public DateTime? RequisitionDate { get; set; }

        public int CargoId { get; set; } = 0;
        public int GangId { get; set; } = 0;

        public string? JobDescription { get; set; }
        public string? GphaRequestId { get; set; }

        public bool ShipSide { get; set; }
        public bool Weekend { get; set; }
        public bool Night { get; set; }

        public string ShiftType { get; set; } = string.Empty;

        public double NormalHours { get; set; }
        public double OvertimeHours { get; set; }

        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public bool Processed { get; set; }
        public bool Stored { get; set; }
        public string? Preparedby { get; set; }
    }

}
