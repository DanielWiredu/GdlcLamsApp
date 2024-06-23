using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwBankBranch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public int BankId { get; set; }

    public string BankName { get; set; } = null!;

    public string SortCode { get; set; } = null!;
}
