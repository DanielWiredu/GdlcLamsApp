using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblLabourAdvice
{
    public int AutoNo { get; set; }

    public string AdviceNo { get; set; } = null!;

    public int DlecodeCompanyId { get; set; }

    public string WorkerId { get; set; } = null!;

    public int? TradegroupId { get; set; }

    public int? TradetypeId { get; set; }

    public int? ReportpointId { get; set; }

    public int? LocationId { get; set; }

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public string? Preparedby { get; set; }

    public bool? Processed { get; set; }

    public string? Processedby { get; set; }

    public string? LabourType { get; set; }

    public string? ReqNo { get; set; }

    public virtual ICollection<TblLabourAdviceDay> TblLabourAdviceDays { get; set; } = new List<TblLabourAdviceDay>();
}
