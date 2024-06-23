using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblBankBranch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public int BankId { get; set; }

    public string SortCode { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }
}
