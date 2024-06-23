using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyCostSheet
{
    public int AutoNo { get; set; }

    public string ReqNo { get; set; } = null!;

    public string DlecodeCompanyName { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string? TradegroupName { get; set; }

    public string? TradetypeName { get; set; }

    public string? ReportingPoint { get; set; }

    public string? Location { get; set; }

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public string? Preparedby { get; set; }

    public DateTime TransDate { get; set; }

    public double Normal { get; set; }

    public double Overtime { get; set; }

    public string? Night { get; set; }

    public string? Weekends { get; set; }

    public string? Holiday { get; set; }

    public string? Remarks { get; set; }

    public bool OnBoardAllowance { get; set; }

    public string? VesselName { get; set; }

    public bool? Approved { get; set; }
}
