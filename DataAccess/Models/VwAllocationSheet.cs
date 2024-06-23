using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwAllocationSheet
{
    public int Id { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string VesselName { get; set; } = null!;

    public string? ReportingPoint { get; set; }

    public string GangName { get; set; } = null!;

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public string WorkShift { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string? TradegroupName { get; set; }

    public string? CreatedBy { get; set; }
}
