using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblGphaLabourRequest
{
    public int Id { get; set; }

    public DateTime? RequestDate { get; set; }

    public string LabourRequestId { get; set; } = null!;

    public string? UnitDescription { get; set; }

    public string? JobRequested { get; set; }

    public string? NumberRequested { get; set; }

    public string? NeededOn { get; set; }

    public DateTime? RNeededOn { get; set; }

    public string? RDay { get; set; }

    public string? RShift { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? HasCostSheet { get; set; }

    public string? CostSheetNo { get; set; }

    public bool? GphaApproved { get; set; }

    public DateTime? GphaApprovedDate { get; set; }

    public DateTime? SyncDate { get; set; }

    public bool? GdlcApproved { get; set; }

    public DateTime? GdlcApprovedDate { get; set; }
}
