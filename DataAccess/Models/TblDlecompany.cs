using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblDlecompany
{
    public int DlecodeCompanyId { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public decimal? Plnoss { get; set; }

    public decimal? Prno { get; set; }

    public decimal? PDist { get; set; }

    public decimal? PInterval { get; set; }

    public string? Dleaddr { get; set; }

    public string? Dletel { get; set; }

    public string? Email { get; set; }

    public string? Fcontp { get; set; }

    public string? Ftel { get; set; }

    public string? Femail { get; set; }

    public string? Pattern { get; set; }

    public string? Ocontp { get; set; }

    public string? Otel { get; set; }

    public string? Oemail { get; set; }

    public string? Acontp { get; set; }

    public string? Atel { get; set; }

    public string? Aemail { get; set; }

    public double? SharePerc { get; set; }

    public bool Active { get; set; }
}
