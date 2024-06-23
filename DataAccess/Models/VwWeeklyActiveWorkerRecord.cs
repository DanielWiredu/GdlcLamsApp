using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyActiveWorkerRecord
{
    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string ReqNo { get; set; } = null!;

    public bool? Approved { get; set; }

    public DateTime Adate { get; set; }

    public bool? Processed { get; set; }

    public DateTime Date { get; set; }

    public string? Ssfno { get; set; }
}
