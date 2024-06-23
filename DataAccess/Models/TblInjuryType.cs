using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblInjuryType
{
    public int InjuryTypeId { get; set; }

    public string InjuryType { get; set; } = null!;
}
