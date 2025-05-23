﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwMonthlyProcessed
{
    public int AutoNum { get; set; }

    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public int? Dwkday { get; set; }

    public int? Dwkend { get; set; }

    public int? Dtotal { get; set; }

    public double? Hrwkday { get; set; }

    public double? Hrwkend { get; set; }

    public int? Nwkday { get; set; }

    public int? Nwkend { get; set; }

    public double? UnionDues { get; set; }

    public double? BasicRate { get; set; }

    public double? OtwkdayRate { get; set; }

    public double? OtwkendRate { get; set; }

    public double? TransportAmount { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string? TradegroupName { get; set; }

    public string? TradetypeName { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string? Location { get; set; }

    public string? ReportingPoint { get; set; }

    public string? Yyyymm { get; set; }

    public DateTime? PayPeriod { get; set; }

    public double? Ssfemployer { get; set; }

    public string? Transport { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public double? AnnualBonus { get; set; }

    public double? AnnualLeave { get; set; }

    public double? PremiumWithoutTt { get; set; }

    public double? BasicRateDle { get; set; }

    public string? DlecompanyStatus { get; set; }

    public string? Tgno { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public int DlecodeCompanyId { get; set; }

    public double? Vat { get; set; }

    public double? GetFund { get; set; }

    public double? Nhil { get; set; }

    public int? PresentAge { get; set; }
}
