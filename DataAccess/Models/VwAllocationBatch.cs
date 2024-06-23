using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwAllocationBatch
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string VesselName { get; set; } = null!;

    public string? ReportingPoint { get; set; }

    public string GangName { get; set; } = null!;

    public string? Job { get; set; }

    public string WorkShift { get; set; } = null!;

    public bool Processed { get; set; }
}
