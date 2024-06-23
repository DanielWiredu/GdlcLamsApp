using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwDailyPf
{
    public string DlecodeCompanyName { get; set; } = null!;

    public string VesselName { get; set; } = null!;

    public string? Location { get; set; }

    public string? ReportingPoint { get; set; }

    public string? GangName { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string TradegroupName { get; set; } = null!;

    public string? CargoName { get; set; }

    public string? Pname { get; set; }

    public string ReqNo { get; set; } = null!;

    public double? Normal { get; set; }

    public bool? Approved { get; set; }

    public DateTime? Adate { get; set; }

    public string WorkerId { get; set; } = null!;

    public int? TradegroupId { get; set; }

    public double? BasicRate { get; set; }

    public double? BasicRateDle { get; set; }

    public string? BankBranch { get; set; }

    public string? BankNumber { get; set; }

    public string? BankName { get; set; }

    public string? Ezwichid { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public string? Ssfno { get; set; }

    public string? SortCode { get; set; }

    public int DlecodeCompanyId { get; set; }
}
