using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwLabourAdvice
{
    public int AutoNo { get; set; }

    public string AdviceNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public DateTime Date { get; set; }

    public int DlecodeCompanyId { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string? WorkerName { get; set; }

    public bool? Processed { get; set; }

    public string? LabourType { get; set; }

    public string? ReqNo { get; set; }
}
