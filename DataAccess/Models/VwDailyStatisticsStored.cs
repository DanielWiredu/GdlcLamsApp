using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwDailyStatisticsStored
{
    public string DlecodeCompanyName { get; set; } = null!;

    public string VesselName { get; set; } = null!;

    public string? Location { get; set; }

    public string? ReportingPoint { get; set; }

    public string? GangName { get; set; }

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? TradegroupName { get; set; }

    public string? CargoName { get; set; }

    public string? Pname { get; set; }

    public string ReqNo { get; set; } = null!;

    public DateTime? Date { get; set; }

    public double? Normal { get; set; }

    public double? Overtime { get; set; }

    public string? Weekends { get; set; }

    public string? Night { get; set; }

    public DateTime? Adate { get; set; }

    public string? Preparedby { get; set; }

    public string? Approvedby { get; set; }

    public string Transport { get; set; } = null!;

    public double? BasicRate { get; set; }

    public int? PresentAge { get; set; }

    public double? TransportAmount { get; set; }

    public double? OnBoardAllowance { get; set; }

    public string? DlecompanyStatus { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public double? Ssfemployer { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public bool? Approved { get; set; }

    public int? TradegroupId { get; set; }

    public double? AnnualBonus { get; set; }

    public double? AnnualLeave { get; set; }

    public double? PremiumWithoutTt { get; set; }

    public double? BasicRateDle { get; set; }

    public double? OvertimeRateDle { get; set; }

    public double? NightRateDle { get; set; }

    public double? Vat { get; set; }

    public double? GetFund { get; set; }

    public double? Nhil { get; set; }
}
