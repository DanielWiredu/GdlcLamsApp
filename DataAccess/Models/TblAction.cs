using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblAction
{
    public int ActionId { get; set; }

    public string Action { get; set; } = null!;
}
