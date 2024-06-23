using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblLocation
{
    public int LocationId { get; set; }

    public string Location { get; set; } = null!;
}
