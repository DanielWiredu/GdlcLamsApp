using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwStaffWreqGangRate
{
    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public int DlecodeCompanyId { get; set; }

    public int? TradegroupId { get; set; }

    public int? TradetypeId { get; set; }

    public int? ReportpointId { get; set; }

    public int? LocationId { get; set; }

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public string? Preparedby { get; set; }

    public bool? Approved { get; set; }

    public string? Approvedby { get; set; }

    public double? Dbwage { get; set; }

    public double? DbwageWkend { get; set; }

    public double? HourOtimeWkday { get; set; }

    public double? HourOtimeWkend { get; set; }

    public double? Nawkday { get; set; }

    public double? Nawkend { get; set; }

    public double? TransportAmount { get; set; }

    public double? DbwageDle { get; set; }

    public double? DbwageWkendDle { get; set; }

    public double? HourOtimeWkdayDle { get; set; }

    public double? HourOtimeWkendDle { get; set; }

    public double? NawkdayDle { get; set; }

    public double? NawkendDle { get; set; }

    public double? Subsidy { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public int? BankId { get; set; }

    public string? BankBranch { get; set; }

    public string? BankNumber { get; set; }

    public bool Tax { get; set; }

    public bool ChargePremium { get; set; }

    public string? Ezwichid { get; set; }

    public int? Age { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? BankBranchId { get; set; }
}
