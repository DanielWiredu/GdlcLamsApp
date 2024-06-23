using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwDailyReq
{
    public int AutoNo { get; set; }

    public string ReqNo { get; set; } = null!;

    public DateTime Date { get; set; }

    public bool Approved { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string VesselName { get; set; } = null!;

    public string? ReportingPoint { get; set; }

    public bool? Submitted { get; set; }

    public bool? Processed { get; set; }

    public bool? HoursConfirmed { get; set; }

    public string? GphaRequestId { get; set; }
}
