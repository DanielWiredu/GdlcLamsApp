using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklySsfContributor
{
    public string ReqNo { get; set; } = null!;

    public string DlecodeCompanyName { get; set; } = null!;

    public string? ReportingPoint { get; set; }

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string TradegroupName { get; set; } = null!;

    public string? TradetypeName { get; set; }

    public double Normal { get; set; }

    public double? Ssfemployee { get; set; }

    public double? BasicRate { get; set; }

    public int? PresentAge { get; set; }

    public string? VesselName { get; set; }

    public string? Ssfno { get; set; }

    public DateTime Adate { get; set; }

    public double? Ssfemployer { get; set; }

    public string? NationalId { get; set; }
}
