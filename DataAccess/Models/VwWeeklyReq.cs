using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyReq
{
    public int AutoNo { get; set; }

    public string ReqNo { get; set; } = null!;

    public DateTime Date { get; set; }

    public string WorkerId { get; set; } = null!;

    public string DlecodeCompanyName { get; set; } = null!;

    public string? WorkerName { get; set; }

    public bool? Approved { get; set; }

    public bool? Confirmed { get; set; }

    public bool? Processed { get; set; }
}
