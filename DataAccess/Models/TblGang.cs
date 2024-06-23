using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblGang
{
    public int GangId { get; set; }

    public string GangName { get; set; } = null!;

    public string? Notes { get; set; }
}
