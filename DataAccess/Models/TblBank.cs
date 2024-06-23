using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblBank
{
    public int BankId { get; set; }

    public string BankName { get; set; } = null!;
}
