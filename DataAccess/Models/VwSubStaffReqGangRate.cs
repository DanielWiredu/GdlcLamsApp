using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwSubStaffReqGangRate
{
    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public int? TradegroupId { get; set; }

    public string Transport { get; set; } = null!;

    public double? Dbwage { get; set; }

    public double? DbwageWkend { get; set; }

    public double? HourOtimeWkday { get; set; }

    public double? HourOtimeWkend { get; set; }

    public double? Nawkday { get; set; }

    public double? Nawkend { get; set; }

    public double? TransportRateAmt { get; set; }

    public double? DbwageDle { get; set; }

    public double? DbwageWkendDle { get; set; }

    public double? HourOtimeWkdayDle { get; set; }

    public double? HourOtimeWkendDle { get; set; }

    public double? NawkdayDle { get; set; }

    public double? NawkendDle { get; set; }

    public double? Subsidy { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public int? Age { get; set; }

    public string? Ezwichid { get; set; }

    public bool Tax { get; set; }

    public bool ChargePremium { get; set; }

    public int? BankId { get; set; }

    public string? BankBranch { get; set; }

    public string? BankNumber { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string WorkerType { get; set; } = null!;

    public double? Normal { get; set; }

    public double? Overtime { get; set; }

    public int? BankBranchId { get; set; }

    public string? PaymentOption { get; set; }
}
