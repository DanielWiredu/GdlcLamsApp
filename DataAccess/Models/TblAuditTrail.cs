using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblAuditTrail
{
    public DateTime ActionDate { get; set; }

    public string ActionBy { get; set; } = null!;

    public string ActionDescription { get; set; } = null!;

    public string? ActionId { get; set; }
}
