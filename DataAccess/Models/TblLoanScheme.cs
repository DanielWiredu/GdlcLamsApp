using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblLoanScheme
{
    public int Id { get; set; }

    public string? LoanScheme { get; set; }

    public string? AccountNo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<TblLoan> TblLoans { get; set; } = new List<TblLoan>();
}
