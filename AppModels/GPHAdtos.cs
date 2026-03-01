using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class GPHACreateLabourRequest
    {
        public Guid Id { get; set; }
        public DateTime RequestDate { get; set; }
        public string? LabourRequestId { get; set; }
        public string? UnitDescription { get; set; }
        public string? JobDescription { get; set; }
        public int NumberRequested { get; set; }
        public DateTime NeededOn { get; set; }
        public string? RequestId { get; set; }
        public string? CompanySecret { get; set; }
        public string? CompanyKey { get; set; }
        public string? GeoLocation { get; set; }
        public string? Shift { get; set; }
        public string? WeekType { get; set; }

    }
    public class GPHACreateCostSheetRequest
    {
        public GPHAJobAssignmentDto JobAssignment { get; set; } = default!;
        public GPHACostSheetDto CostSheet { get; set; } = default!;
        public List<GPHACostSheetDetailDto> CostSheetDetails { get; set; } = new();
    }

    public class GPHAJobAssignmentDto
    {
        public Guid Id { get; set; }
        public int NumberToSupply { get; set; }
        public string Job { get; set; } = string.Empty;
        public Guid CostSheetId { get; set; }
        public DateTime NeededOn { get; set; }
        public bool Shift { get; set; }
        public string DayType { get; set; } = string.Empty;
        public string GeoLocation { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public string RequestNumber { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public int NumberToSupplied { get; set; }
    }

    public class GPHACostSheetDto
    {
        public string LabourCompany { get; set; } = string.Empty;
        public Guid CompanyId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Shift { get; set; } = string.Empty;
        public string CostSheetNumber { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public string PaymentReference { get; set; } = string.Empty;
        public bool PaymentStatus { get; set; }
    }

    public class GPHACostSheetDetailDto
    {
        public Guid Id { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Audited { get; set; }
        public DateTime? AuditedDate { get; set; }
        public string RateType { get; set; } = string.Empty;
        public decimal HoursWorked { get; set; }
        public decimal BaseRate { get; set; }
        public decimal PremiumTotal { get; set; }
        public decimal NHilGflTotal { get; set; }
        public decimal VatTotal { get; set; }
        public decimal TransportationTotal { get; set; }
        public decimal IncentiveTotal { get; set; }
        public string Level { get; set; } = string.Empty;
        public string JobDescription { get; set; } = string.Empty;
        public string Worker { get; set; } = string.Empty;
        public string WorkerId { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public decimal ShiftAllowance { get; set; }
        public decimal NightAllowance { get; set; }
        public decimal Total { get; set; }
        public string Unit { get; set; } = string.Empty;
        public string AuditedBy { get; set; } = string.Empty;
        public decimal OverTimeHours { get; set; }
        public decimal OverTimeRate { get; set; }
        public decimal GroupIncentive { get; set; }
    }
}
