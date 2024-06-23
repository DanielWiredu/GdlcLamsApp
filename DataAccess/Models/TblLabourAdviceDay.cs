using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblLabourAdviceDay
{
    public int AutoId { get; set; }

    public string AdviceNo { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public double Normal { get; set; }

    public double Overtime { get; set; }

    public string? Night { get; set; }

    public string? Weekends { get; set; }

    public string? Holiday { get; set; }

    public string? Remarks { get; set; }

    public int? VesselberthId { get; set; }

    public string? Transport { get; set; }

    public bool OnBoardAllowance { get; set; }

    public TimeOnly? HrsFrom { get; set; }

    public TimeOnly? HrsTo { get; set; }

    public virtual TblLabourAdvice AdviceNoNavigation { get; set; } = null!;
}
