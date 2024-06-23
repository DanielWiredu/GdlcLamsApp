using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyTax
{
    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string? Ssfno { get; set; }

    public double Normal { get; set; }

    public double? BasicRate { get; set; }

    public DateTime Adate { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public int? TradetypeId { get; set; }

    public string? TradetypeName { get; set; }

    public double Overtime { get; set; }

    public string? Weekends { get; set; }

    public double? Ssfemployee { get; set; }

    public double? TaxOnBasic { get; set; }

    public double? TaxOnOvertime { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? OvertimeRate { get; set; }

    public int? PresentAge { get; set; }

    public double? TaxOnTransport { get; set; }

    public string? Transport { get; set; }

    public double? TransportAmount { get; set; }

    public double? OnBoardAllowance { get; set; }

    public string? NationalId { get; set; }
}
