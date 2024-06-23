using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblAllocationBatch
{
    public int Id { get; set; }

    public int DlecodeCompanyId { get; set; }

    public int? VesselberthId { get; set; }

    public int? ReportpointId { get; set; }

    public int? GangId { get; set; }

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public string WorkShift { get; set; } = null!;

    public bool Processed { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public string? ReqNo { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<TblAllocationWorker> TblAllocationWorkers { get; set; } = new List<TblAllocationWorker>();
}
