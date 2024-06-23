using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblStaffWreq
{
    public int AutoNo { get; set; }

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

    public bool? Processed { get; set; }

    public string? Processedby { get; set; }

    public bool? Paid { get; set; }

    public string? Paidby { get; set; }

    public DateTime? PaidDate { get; set; }

    public bool? Stored { get; set; }

    public string? Storedby { get; set; }

    public bool? Confirmed { get; set; }

    public bool? DuplicateShift { get; set; }

    public virtual ICollection<TblSubStaffWreq> TblSubStaffWreqs { get; set; } = new List<TblSubStaffWreq>();
}
