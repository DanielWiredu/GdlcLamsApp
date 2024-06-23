using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblErrorLog
{
    public int RowId { get; set; }

    public DateTime ErrorDate { get; set; }

    public string? ErrorMessage { get; set; }

    public string? ErrorPage { get; set; }

    public string? ErrorUser { get; set; }
}
