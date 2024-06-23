using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWorkersIdcard
{
    public string WorkerId { get; set; } = null!;

    public string WorkerType { get; set; } = null!;

    public string? WorkerName { get; set; }

    public DateTime? DateBirth { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public byte[]? Pics { get; set; }
}
