using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwStaffMreqGangRate
{
    public string ReqNo { get; set; } = null!;

    public int DlecodeCompanyId { get; set; }

    public string WorkerId { get; set; } = null!;

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

    public int? Dwkday { get; set; }

    public int? Dwkend { get; set; }

    public int? Dtotal { get; set; }

    public double? Hrwkday { get; set; }

    public double? Hrwkend { get; set; }

    public int? Nwkday { get; set; }

    public int? Nwkend { get; set; }

    public string? Yyyymm { get; set; }

    public DateTime? PeriodStart { get; set; }

    public DateTime? PeriodEnd { get; set; }

    public string? Transport { get; set; }

    public double? Dbwage { get; set; }

    public double? HourOtimeWkday { get; set; }

    public double? HourOtimeWkend { get; set; }

    public double? TransportAmt { get; set; }

    public double? DbwageDle { get; set; }

    public double? HourOtimeWkdayDle { get; set; }

    public double? HourOtimeWkendDle { get; set; }

    public double? Subsidy { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public int? BankId { get; set; }

    public int? BankBranchId { get; set; }

    public string? BankNumber { get; set; }

    public bool Tax { get; set; }

    public bool ChargePremium { get; set; }

    public string? Ezwichid { get; set; }

    public int? Age { get; set; }

    public string? PaymentOption { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }
}
