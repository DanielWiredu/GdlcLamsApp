using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwDailyCostSheet
{
    public string ReqNo { get; set; } = null!;

    public DateTime Date { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string? VesselName { get; set; }

    public string? Location { get; set; }

    public string? ReportingPoint { get; set; }

    public string? GangName { get; set; }

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? TradegroupName { get; set; }

    public bool Weekends { get; set; }

    public bool Night { get; set; }

    public string? Preparedby { get; set; }

    public bool? OnBoardAllowance { get; set; }

    public string? CargoName { get; set; }

    public string? Pname { get; set; }

    public string? Ezwichid { get; set; }

    public bool Approved { get; set; }
}
