using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblStaffReq
{
    public int AutoNo { get; set; }

    public string ReqNo { get; set; } = null!;

    public int DlecodeCompanyId { get; set; }

    public int? VesselberthId { get; set; }

    public int? LocationId { get; set; }

    public int? ReportpointId { get; set; }

    public int? CargoId { get; set; }

    public int? GangId { get; set; }

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public double Normal { get; set; }

    public double Overtime { get; set; }

    public bool Weekends { get; set; }

    public bool Night { get; set; }

    public bool Approved { get; set; }

    public DateTime Adate { get; set; }

    public string? Preparedby { get; set; }

    public string? Approvedby { get; set; }

    public bool? Processed { get; set; }

    public string? Processedby { get; set; }

    public bool? Paid { get; set; }

    public string? Paidby { get; set; }

    public DateTime? PaidDate { get; set; }

    public bool? OnBoardAllowance { get; set; }

    public bool? Stored { get; set; }

    public string? Storedby { get; set; }

    public string? Hourby { get; set; }

    public DateTime? HourDate { get; set; }

    public TimeOnly? NormalHrsFrom { get; set; }

    public TimeOnly? NormalHrsTo { get; set; }

    public TimeOnly? OvertimeHrsFrom { get; set; }

    public TimeOnly? OvertimeHrsTo { get; set; }

    public bool? Submitted { get; set; }

    public string? SubmittedBy { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public bool? PullStatus { get; set; }

    public DateTime? PullDate { get; set; }

    public bool? HoursConfirmed { get; set; }

    public string? GphaRequestId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<TblSubStaffReq> TblSubStaffReqs { get; set; } = new List<TblSubStaffReq>();
}
