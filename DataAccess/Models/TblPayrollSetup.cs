using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblPayrollSetup
{
    public int Id { get; set; }

    public double? UnionDues { get; set; }

    public double? Welfare { get; set; }

    public double? Medicals { get; set; }

    public double? Ssfemployee { get; set; }

    public double? Ssfemployer { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public double? AnnualBonus { get; set; }

    public double? AnnualLeave { get; set; }

    public double? PremiumShareHolder { get; set; }

    public double? PremiumNonShareHolder { get; set; }

    public double? PremiumWithoutTt { get; set; }

    public double? TaxOnBonus { get; set; }

    public double? TaxOnBasic { get; set; }

    public double? TaxOnOvertime { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? TaxOnTransport { get; set; }

    public double? OnBoardAllowance { get; set; }

    public double? Vat { get; set; }

    public double? GetFund { get; set; }

    public double? Nhil { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool? UpdateStatus { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
