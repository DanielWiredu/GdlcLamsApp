using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public partial class GdlcdbContext : DbContext
{
    public GdlcdbContext()
    {
    }

    public GdlcdbContext(DbContextOptions<GdlcdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAction> TblActions { get; set; }

    public virtual DbSet<TblAllocationBatch> TblAllocationBatches { get; set; }

    public virtual DbSet<TblAllocationWorker> TblAllocationWorkers { get; set; }

    public virtual DbSet<TblApproveDaily> TblApproveDailies { get; set; }

    public virtual DbSet<TblApproveMonthly> TblApproveMonthlies { get; set; }

    public virtual DbSet<TblApproveWeekly> TblApproveWeeklies { get; set; }

    public virtual DbSet<TblAuditTrail> TblAuditTrails { get; set; }

    public virtual DbSet<TblBank> TblBanks { get; set; }

    public virtual DbSet<TblBankBranch> TblBankBranches { get; set; }

    public virtual DbSet<TblCargo> TblCargos { get; set; }

    public virtual DbSet<TblDisapproveDaily> TblDisapproveDailies { get; set; }

    public virtual DbSet<TblDisapproveMonthly> TblDisapproveMonthlies { get; set; }

    public virtual DbSet<TblDisapproveWeekly> TblDisapproveWeeklies { get; set; }

    public virtual DbSet<TblDlecompany> TblDlecompanies { get; set; }

    public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }

    public virtual DbSet<TblGang> TblGangs { get; set; }

    public virtual DbSet<TblGphaLabourRequest> TblGphaLabourRequests { get; set; }

    public virtual DbSet<TblHospital> TblHospitals { get; set; }

    public virtual DbSet<TblInjuryType> TblInjuryTypes { get; set; }

    public virtual DbSet<TblLabourAdvice> TblLabourAdvices { get; set; }

    public virtual DbSet<TblLabourAdviceDay> TblLabourAdviceDays { get; set; }

    public virtual DbSet<TblLoan> TblLoans { get; set; }

    public virtual DbSet<TblLoanRepayment> TblLoanRepayments { get; set; }

    public virtual DbSet<TblLoanScheme> TblLoanSchemes { get; set; }

    public virtual DbSet<TblLocation> TblLocations { get; set; }

    public virtual DbSet<TblNationality> TblNationalities { get; set; }

    public virtual DbSet<TblPayrollSetup> TblPayrollSetups { get; set; }

    public virtual DbSet<TblReportingPoint> TblReportingPoints { get; set; }

    public virtual DbSet<TblStaffMreq> TblStaffMreqs { get; set; }

    public virtual DbSet<TblStaffReq> TblStaffReqs { get; set; }

    public virtual DbSet<TblStaffWreq> TblStaffWreqs { get; set; }

    public virtual DbSet<TblStoredDaily> TblStoredDailies { get; set; }

    public virtual DbSet<TblStoredMonthly> TblStoredMonthlies { get; set; }

    public virtual DbSet<TblStoredWeekly> TblStoredWeeklies { get; set; }

    public virtual DbSet<TblSubStaffReq> TblSubStaffReqs { get; set; }

    public virtual DbSet<TblSubStaffWreq> TblSubStaffWreqs { get; set; }

    public virtual DbSet<TblTradeGroup> TblTradeGroups { get; set; }

    public virtual DbSet<TblTradeGroupRate> TblTradeGroupRates { get; set; }

    public virtual DbSet<TblTradeType> TblTradeTypes { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserRole> TblUserRoles { get; set; }

    public virtual DbSet<TblVessel> TblVessels { get; set; }

    public virtual DbSet<TblWorker> TblWorkers { get; set; }

    public virtual DbSet<TblWorkersIdcard> TblWorkersIdcards { get; set; }

    public virtual DbSet<VwAllocationBatch> VwAllocationBatches { get; set; }

    public virtual DbSet<VwAllocationSheet> VwAllocationSheets { get; set; }

    public virtual DbSet<VwAllocationWorker> VwAllocationWorkers { get; set; }

    public virtual DbSet<VwBankBranch> VwBankBranches { get; set; }

    public virtual DbSet<VwDailyActiveVessel> VwDailyActiveVessels { get; set; }

    public virtual DbSet<VwDailyActiveWorker> VwDailyActiveWorkers { get; set; }

    public virtual DbSet<VwDailyActiveWorkerRecord> VwDailyActiveWorkerRecords { get; set; }

    public virtual DbSet<VwDailyApproved> VwDailyApproveds { get; set; }

    public virtual DbSet<VwDailyApprovedCostSheet> VwDailyApprovedCostSheets { get; set; }

    public virtual DbSet<VwDailyCostSheet> VwDailyCostSheets { get; set; }

    public virtual DbSet<VwDailyInvoice> VwDailyInvoices { get; set; }

    public virtual DbSet<VwDailyInvoiceStored> VwDailyInvoiceStoreds { get; set; }

    public virtual DbSet<VwDailyLeaveBonu> VwDailyLeaveBonus { get; set; }

    public virtual DbSet<VwDailyPayroll> VwDailyPayrolls { get; set; }

    public virtual DbSet<VwDailyPf> VwDailyPfs { get; set; }

    public virtual DbSet<VwDailyProcessed> VwDailyProcesseds { get; set; }

    public virtual DbSet<VwDailyReportCasting> VwDailyReportCastings { get; set; }

    public virtual DbSet<VwDailyReportListing> VwDailyReportListings { get; set; }

    public virtual DbSet<VwDailyReportListingDisapproved> VwDailyReportListingDisapproveds { get; set; }

    public virtual DbSet<VwDailyReportListingStored> VwDailyReportListingStoreds { get; set; }

    public virtual DbSet<VwDailyReq> VwDailyReqs { get; set; }

    public virtual DbSet<VwDailySsf> VwDailySsfs { get; set; }

    public virtual DbSet<VwDailySsfApproved> VwDailySsfApproveds { get; set; }

    public virtual DbSet<VwDailySsfContributor> VwDailySsfContributors { get; set; }

    public virtual DbSet<VwDailySsfNonContributor> VwDailySsfNonContributors { get; set; }

    public virtual DbSet<VwDailyStatistic> VwDailyStatistics { get; set; }

    public virtual DbSet<VwDailyStatisticsStored> VwDailyStatisticsStoreds { get; set; }

    public virtual DbSet<VwDailyTax> VwDailyTaxes { get; set; }

    public virtual DbSet<VwLabourAdvice> VwLabourAdvices { get; set; }

    public virtual DbSet<VwLabourAdviceDay> VwLabourAdviceDays { get; set; }

    public virtual DbSet<VwLoan> VwLoans { get; set; }

    public virtual DbSet<VwLoanRepayment> VwLoanRepayments { get; set; }

    public virtual DbSet<VwMonthlyApprovedCostSheet> VwMonthlyApprovedCostSheets { get; set; }

    public virtual DbSet<VwMonthlyBankPayment> VwMonthlyBankPayments { get; set; }

    public virtual DbSet<VwMonthlyInvoice> VwMonthlyInvoices { get; set; }

    public virtual DbSet<VwMonthlyInvoiceStored> VwMonthlyInvoiceStoreds { get; set; }

    public virtual DbSet<VwMonthlyLeaveBonu> VwMonthlyLeaveBonus { get; set; }

    public virtual DbSet<VwMonthlyLeaveBonusPaySlip> VwMonthlyLeaveBonusPaySlips { get; set; }

    public virtual DbSet<VwMonthlyPayroll> VwMonthlyPayrolls { get; set; }

    public virtual DbSet<VwMonthlyPf> VwMonthlyPfs { get; set; }

    public virtual DbSet<VwMonthlyPreviewCostSheet> VwMonthlyPreviewCostSheets { get; set; }

    public virtual DbSet<VwMonthlyProcessed> VwMonthlyProcesseds { get; set; }

    public virtual DbSet<VwMonthlyReportListing> VwMonthlyReportListings { get; set; }

    public virtual DbSet<VwMonthlyReportListingDisapproved> VwMonthlyReportListingDisapproveds { get; set; }

    public virtual DbSet<VwMonthlyReportListingPreview> VwMonthlyReportListingPreviews { get; set; }

    public virtual DbSet<VwMonthlyReportListingStored> VwMonthlyReportListingStoreds { get; set; }

    public virtual DbSet<VwMonthlyReq> VwMonthlyReqs { get; set; }

    public virtual DbSet<VwMonthlySsf> VwMonthlySsfs { get; set; }

    public virtual DbSet<VwMonthlyStatistic> VwMonthlyStatistics { get; set; }

    public virtual DbSet<VwMonthlyStatisticsStored> VwMonthlyStatisticsStoreds { get; set; }

    public virtual DbSet<VwMonthlyTax> VwMonthlyTaxes { get; set; }

    public virtual DbSet<VwStaffMreqGangRate> VwStaffMreqGangRates { get; set; }

    public virtual DbSet<VwStaffWreqGangRate> VwStaffWreqGangRates { get; set; }

    public virtual DbSet<VwSubStaffReq> VwSubStaffReqs { get; set; }

    public virtual DbSet<VwSubStaffReqGangRate> VwSubStaffReqGangRates { get; set; }

    public virtual DbSet<VwSubStaffWreq> VwSubStaffWreqs { get; set; }

    public virtual DbSet<VwTblWorker> VwTblWorkers { get; set; }

    public virtual DbSet<VwTradeType> VwTradeTypes { get; set; }

    public virtual DbSet<VwWeeklyActiveVessel> VwWeeklyActiveVessels { get; set; }

    public virtual DbSet<VwWeeklyActiveWorker> VwWeeklyActiveWorkers { get; set; }

    public virtual DbSet<VwWeeklyActiveWorkerRecord> VwWeeklyActiveWorkerRecords { get; set; }

    public virtual DbSet<VwWeeklyApproved> VwWeeklyApproveds { get; set; }

    public virtual DbSet<VwWeeklyApprovedCostSheet> VwWeeklyApprovedCostSheets { get; set; }

    public virtual DbSet<VwWeeklyCostSheet> VwWeeklyCostSheets { get; set; }

    public virtual DbSet<VwWeeklyInvoice> VwWeeklyInvoices { get; set; }

    public virtual DbSet<VwWeeklyInvoiceStored> VwWeeklyInvoiceStoreds { get; set; }

    public virtual DbSet<VwWeeklyLeaveBonu> VwWeeklyLeaveBonus { get; set; }

    public virtual DbSet<VwWeeklyPayroll> VwWeeklyPayrolls { get; set; }

    public virtual DbSet<VwWeeklyPf> VwWeeklyPfs { get; set; }

    public virtual DbSet<VwWeeklyProcessed> VwWeeklyProcesseds { get; set; }

    public virtual DbSet<VwWeeklyReportListing> VwWeeklyReportListings { get; set; }

    public virtual DbSet<VwWeeklyReportListingDisapproved> VwWeeklyReportListingDisapproveds { get; set; }

    public virtual DbSet<VwWeeklyReportListingStored> VwWeeklyReportListingStoreds { get; set; }

    public virtual DbSet<VwWeeklyReq> VwWeeklyReqs { get; set; }

    public virtual DbSet<VwWeeklySsf> VwWeeklySsfs { get; set; }

    public virtual DbSet<VwWeeklySsfApproved> VwWeeklySsfApproveds { get; set; }

    public virtual DbSet<VwWeeklySsfContributor> VwWeeklySsfContributors { get; set; }

    public virtual DbSet<VwWeeklySsfNonContributor> VwWeeklySsfNonContributors { get; set; }

    public virtual DbSet<VwWeeklyStatistic> VwWeeklyStatistics { get; set; }

    public virtual DbSet<VwWeeklyStatisticsStored> VwWeeklyStatisticsStoreds { get; set; }

    public virtual DbSet<VwWeeklyTax> VwWeeklyTaxes { get; set; }

    public virtual DbSet<VwWorker> VwWorkers { get; set; }

    public virtual DbSet<VwWorkerDetail> VwWorkerDetails { get; set; }

    public virtual DbSet<VwWorkerDetailsReport> VwWorkerDetailsReports { get; set; }

    public virtual DbSet<VwWorkerList> VwWorkerLists { get; set; }

    public virtual DbSet<VwWorkerListTagged> VwWorkerListTaggeds { get; set; }

    public virtual DbSet<VwWorkerListUntagged> VwWorkerListUntaggeds { get; set; }

    public virtual DbSet<VwWorkersIdcard> VwWorkersIdcards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=GDLCDB;Trusted_Connection=True;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAction>(entity =>
        {
            entity.HasKey(e => e.ActionId);

            entity.ToTable("tblActions");

            entity.HasIndex(e => e.Action, "IX_tblActions").IsUnique();

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAllocationBatch>(entity =>
        {
            entity.ToTable("tblAllocationBatch");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.GangId).HasColumnName("gangID");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.WorkShift)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAllocationWorker>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("tblAllocationWorkers");

            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");

            entity.HasOne(d => d.BatchNoNavigation).WithMany(p => p.TblAllocationWorkers)
                .HasForeignKey(d => d.BatchNo)
                .HasConstraintName("FK_tblAllocationWorkers_tblAllocationBatch");
        });

        modelBuilder.Entity<TblApproveDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblApproveDaily");

            entity.HasIndex(e => e.ReqNo, "IK_tblPayDaily");

            entity.HasIndex(e => e.Adate, "IX_tblPayDaily");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoId).HasColumnName("cargoID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangId).HasColumnName("gangID");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("locationID");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.Paid).HasDefaultValue(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Stored).HasDefaultValue(false);
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblApproveDaily_tblStaffReq");
        });

        modelBuilder.Entity<TblApproveMonthly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblApproveMonthly");

            entity.HasIndex(e => e.ReqNo, "IX_tblApproveMonthly");

            entity.HasIndex(e => e.Adate, "IX_tblApproveMonthly_1");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkdayRateDle).HasColumnName("OTWkdayRateDLE");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.OtwkendRateDle).HasColumnName("OTWkendRateDLE");
            entity.Property(e => e.Paid).HasDefaultValue(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEnd).HasColumnType("datetime");
            entity.Property(e => e.PeriodStart).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Stored).HasDefaultValue(false);
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblApproveMonthly_tblStaffMReq");
        });

        modelBuilder.Entity<TblApproveWeekly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblApproveWeekly");

            entity.HasIndex(e => e.ReqNo, "IX_tblApproveWeekly");

            entity.HasIndex(e => e.Adate, "IX_tblApproveWeekly_1");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.Paid).HasDefaultValue(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Stored).HasDefaultValue(false);
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblApproveWeekly_tblStaffWReq");
        });

        modelBuilder.Entity<TblAuditTrail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAuditTrail");

            entity.HasIndex(e => new { e.ActionDate, e.ActionBy }, "IX_tblAuditTrail");

            entity.Property(e => e.ActionBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.ActionDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ActionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ActionID");
        });

        modelBuilder.Entity<TblBank>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("tblBanks");

            entity.HasIndex(e => e.BankName, "IX_tblBanks").IsUnique();

            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBankBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId);

            entity.ToTable("tblBankBranches");

            entity.HasIndex(e => e.SortCode, "IX_tblBankBranches").IsUnique();

            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCargo>(entity =>
        {
            entity.HasKey(e => e.CargoId);

            entity.ToTable("tblCargo");

            entity.HasIndex(e => e.CargoName, "IX_tblCargo").IsUnique();

            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDisapproveDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDisapproveDaily");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoId).HasColumnName("cargoID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangId).HasColumnName("gangID");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("locationID");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDisapproveDaily_tblStaffReq");
        });

        modelBuilder.Entity<TblDisapproveMonthly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDisapproveMonthly");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkdayRateDle).HasColumnName("OTWkdayRateDLE");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.OtwkendRateDle).HasColumnName("OTWkendRateDLE");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEnd).HasColumnType("datetime");
            entity.Property(e => e.PeriodStart).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDisapproveMonthly_tblStaffMReq");
        });

        modelBuilder.Entity<TblDisapproveWeekly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDisapproveWeekly");

            entity.HasIndex(e => e.ReqNo, "IX_tblDisapproveWeekly");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDisapproveWeekly_tblStaffWReq");
        });

        modelBuilder.Entity<TblDlecompany>(entity =>
        {
            entity.HasKey(e => e.DlecodeCompanyId);

            entity.ToTable("tblDLECompany");

            entity.HasIndex(e => e.DlecodeCompanyName, "IX_tblDLECompany").IsUnique();

            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.Acontp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AContp");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Aemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AEmail");
            entity.Property(e => e.Atel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dleaddr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEaddr");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dletel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEtel");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fcontp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FContp");
            entity.Property(e => e.Femail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEmail");
            entity.Property(e => e.Ftel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ocontp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OContp");
            entity.Property(e => e.Oemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OEmail");
            entity.Property(e => e.Otel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PDist)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("P_dist");
            entity.Property(e => e.PInterval)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("P_interval");
            entity.Property(e => e.Pattern)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Plnoss)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("plnoss");
            entity.Property(e => e.Prno)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prno");
        });

        modelBuilder.Entity<TblErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblErrorLog");

            entity.HasIndex(e => e.ErrorDate, "IX_tblErrorLog");

            entity.Property(e => e.ErrorDate).HasColumnType("datetime");
            entity.Property(e => e.ErrorMessage).IsUnicode(false);
            entity.Property(e => e.ErrorPage).IsUnicode(false);
            entity.Property(e => e.ErrorUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RowId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblGang>(entity =>
        {
            entity.HasKey(e => e.GangId);

            entity.ToTable("tblGangs");

            entity.HasIndex(e => e.GangName, "IX_tblGangs").IsUnique();

            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblGphaLabourRequest>(entity =>
        {
            entity.ToTable("tblGPHA_LabourRequests");

            entity.HasIndex(e => e.LabourRequestId, "IX_tblGPHA_LabourRequests");

            entity.Property(e => e.CostSheetNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GdlcApproved)
                .HasDefaultValue(false)
                .HasColumnName("GDLC_Approved");
            entity.Property(e => e.GdlcApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("GDLC_ApprovedDate");
            entity.Property(e => e.GphaApproved)
                .HasDefaultValue(false)
                .HasColumnName("GPHA_Approved");
            entity.Property(e => e.GphaApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("GPHA_ApprovedDate");
            entity.Property(e => e.HasCostSheet)
                .HasDefaultValue(false)
                .HasColumnName("hasCostSheet");
            entity.Property(e => e.JobRequested)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LabourRequestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LabourRequestID");
            entity.Property(e => e.NeededOn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumberRequested)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RDay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rDay");
            entity.Property(e => e.RNeededOn)
                .HasColumnType("datetime")
                .HasColumnName("rNeededOn");
            entity.Property(e => e.RShift)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rShift");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.SyncDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UnitDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblHospital>(entity =>
        {
            entity.HasKey(e => e.HospitalId);

            entity.ToTable("tblHospital");

            entity.HasIndex(e => e.HospitalName, "IX_tblHospital").IsUnique();

            entity.Property(e => e.HospitalName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblInjuryType>(entity =>
        {
            entity.HasKey(e => e.InjuryTypeId).HasName("PK_InjuryType");

            entity.ToTable("tblInjuryType");

            entity.HasIndex(e => e.InjuryType, "IX_InjuryType").IsUnique();

            entity.Property(e => e.InjuryType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLabourAdvice>(entity =>
        {
            entity.HasKey(e => e.AdviceNo);

            entity.ToTable("tblLabourAdvice");

            entity.Property(e => e.AdviceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LabourType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Processed).HasDefaultValue(false);
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<TblLabourAdviceDay>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("tblLabourAdviceDays");

            entity.Property(e => e.AutoId).ValueGeneratedNever();
            entity.Property(e => e.AdviceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HrsFrom).HasPrecision(0);
            entity.Property(e => e.HrsTo).HasPrecision(0);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.HasOne(d => d.AdviceNoNavigation).WithMany(p => p.TblLabourAdviceDays)
                .HasForeignKey(d => d.AdviceNo)
                .HasConstraintName("FK_tblLabourAdviceDays_tblLabourAdvice");
        });

        modelBuilder.Entity<TblLoan>(entity =>
        {
            entity.HasKey(e => e.LoanNo);

            entity.ToTable("tblLoans");

            entity.Property(e => e.LoanNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LoanBalance).HasComputedColumnSql("([LoanAmount]-[RepaidAmount])", false);
            entity.Property(e => e.LoanDate).HasColumnType("datetime");
            entity.Property(e => e.Repaid).HasDefaultValue(false);
            entity.Property(e => e.RepaidAmount).HasDefaultValue(0.0);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.LoanScheme).WithMany(p => p.TblLoans)
                .HasForeignKey(d => d.LoanSchemeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLoans_tblLoanSchemes");
        });

        modelBuilder.Entity<TblLoanRepayment>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("tblLoanRepayments", tb =>
                {
                    tb.HasTrigger("trgUpdateLoanRepaid");
                    tb.HasTrigger("trgUpdateLoanRepaidOnDelete");
                    tb.HasTrigger("trgUpdateLoanRepaidOnUpdate");
                });

            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LoanNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ManualReceiptNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RepayDate).HasColumnType("datetime");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLoanScheme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblLoanShemes");

            entity.ToTable("tblLoanSchemes");

            entity.HasIndex(e => e.LoanScheme, "IX_tblLoanSchemes").IsUnique();

            entity.Property(e => e.AccountNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LoanScheme)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("tblLocation");

            entity.HasIndex(e => e.Location, "IX_tblLocation").IsUnique();

            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblNationality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Nationality");

            entity.ToTable("tblNationality");

            entity.HasIndex(e => e.Nationality, "IX_Nationality").IsUnique();

            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblPayrollSetup>(entity =>
        {
            entity.ToTable("tblPayrollSetup");

            entity.HasIndex(e => e.EffectiveDate, "IX_tblPayrollSetup").IsUnique();

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.UpdateStatus).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblReportingPoint>(entity =>
        {
            entity.HasKey(e => e.ReportingPointId);

            entity.ToTable("tblReportingPoint");

            entity.HasIndex(e => e.ReportingPoint, "IX_tblReportingPoint").IsUnique();

            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblStaffMreq>(entity =>
        {
            entity.HasKey(e => e.ReqNo);

            entity.ToTable("tblStaffMReq");

            entity.HasIndex(e => e.Adate, "IX_tblStaffMReq");

            entity.HasIndex(e => new { e.WorkerId, e.TradegroupId }, "IX_tblStaffMReq_1");

            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AutoNo).ValueGeneratedOnAdd();
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Paid).HasDefaultValue(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEnd).HasColumnType("datetime");
            entity.Property(e => e.PeriodStart).HasColumnType("datetime");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Processed).HasDefaultValue(false);
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.Stored).HasDefaultValue(false);
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("*")
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblStaffReq>(entity =>
        {
            entity.HasKey(e => e.ReqNo);

            entity.ToTable("tblStaffReq");

            entity.HasIndex(e => e.AutoNo, "IX_tblStaffReq").IsUnique();

            entity.HasIndex(e => e.Adate, "IX_tblStaffReq_1");

            entity.HasIndex(e => e.Date, "IX_tblStaffReq_2");

            entity.HasIndex(e => e.GphaRequestId, "IX_tblStaffReq_3");

            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AutoNo).ValueGeneratedOnAdd();
            entity.Property(e => e.CargoId).HasColumnName("cargoID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.GangId).HasColumnName("gangID");
            entity.Property(e => e.GphaRequestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_RequestID");
            entity.Property(e => e.HourDate).HasColumnType("datetime");
            entity.Property(e => e.Hourby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoursConfirmed).HasDefaultValue(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("locationID");
            entity.Property(e => e.NormalHrsFrom).HasPrecision(0);
            entity.Property(e => e.NormalHrsTo).HasPrecision(0);
            entity.Property(e => e.OvertimeHrsFrom).HasPrecision(0);
            entity.Property(e => e.OvertimeHrsTo).HasPrecision(0);
            entity.Property(e => e.Paid).HasDefaultValue(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Processed).HasDefaultValue(false);
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PullDate).HasColumnType("datetime");
            entity.Property(e => e.PullStatus).HasDefaultValue(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.Stored).HasDefaultValue(false);
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Submitted).HasDefaultValue(false);
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
        });

        modelBuilder.Entity<TblStaffWreq>(entity =>
        {
            entity.HasKey(e => e.ReqNo);

            entity.ToTable("tblStaffWReq");

            entity.HasIndex(e => e.Adate, "IX_tblStaffWReq");

            entity.HasIndex(e => new { e.WorkerId, e.TradegroupId }, "IX_tblStaffWReq_1");

            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approved).HasDefaultValue(false);
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AutoNo).ValueGeneratedOnAdd();
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DuplicateShift).HasDefaultValue(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Paid).HasDefaultValue(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Processed).HasDefaultValue(false);
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.Stored).HasDefaultValue(false);
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<TblStoredDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblStoredDaily");

            entity.HasIndex(e => e.ReqNo, "IX_tblStoredDaily");

            entity.HasIndex(e => e.Adate, "IX_tblStoredDaily_1");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoId).HasColumnName("cargoID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangId).HasColumnName("gangID");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("locationID");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoredDaily_tblStaffReq");
        });

        modelBuilder.Entity<TblStoredMonthly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblStoredMonthly");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkdayRateDle).HasColumnName("OTWkdayRateDLE");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.OtwkendRateDle).HasColumnName("OTWkendRateDLE");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEnd).HasColumnType("datetime");
            entity.Property(e => e.PeriodStart).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoredMonthly_tblStaffMReq");
        });

        modelBuilder.Entity<TblStoredWeekly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblStoredWeekly");

            entity.HasIndex(e => e.ReqNo, "IX_tblStoredWeekly");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateStored).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateStored).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Paidby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateStored).HasColumnType("datetime");
            entity.Property(e => e.Storedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");

            entity.HasOne(d => d.ReqNoNavigation).WithMany()
                .HasForeignKey(d => d.ReqNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoredWeekly_tblStaffWReq");
        });

        modelBuilder.Entity<TblSubStaffReq>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("tblSubStaffReq");

            entity.HasIndex(e => new { e.ReqNo, e.WorkerId }, "IX_tblSubStaffReq").IsUnique();

            entity.HasIndex(e => new { e.WorkerId, e.TradegroupId }, "IX_tblSubStaffReq_1");

            entity.Property(e => e.Normal).HasDefaultValue(0.0);
            entity.Property(e => e.Overtime).HasDefaultValue(0.0);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");

            entity.HasOne(d => d.ReqNoNavigation).WithMany(p => p.TblSubStaffReqs)
                .HasForeignKey(d => d.ReqNo)
                .HasConstraintName("FK_tblSubStaffReq_tblStaffReq");
        });

        modelBuilder.Entity<TblSubStaffWreq>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("tblSubStaffWReq");

            entity.HasIndex(e => new { e.ReqNo, e.TransDate }, "IX_tblSubStaffWReq");

            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.HasOne(d => d.ReqNoNavigation).WithMany(p => p.TblSubStaffWreqs)
                .HasForeignKey(d => d.ReqNo)
                .HasConstraintName("FK_tblSubStaffWReq_tblStaffWReq");
        });

        modelBuilder.Entity<TblTradeGroup>(entity =>
        {
            entity.HasKey(e => e.TradegroupId);

            entity.ToTable("tblTradeGroup");

            entity.HasIndex(e => e.TradegroupName, "IX_tblTradeGroup").IsUnique();

            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Dnotes)
                .HasColumnType("ntext")
                .HasColumnName("DNOTES");
            entity.Property(e => e.GphaGroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_GroupId");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
        });

        modelBuilder.Entity<TblTradeGroupRate>(entity =>
        {
            entity.ToTable("tblTradeGroupRates");

            entity.HasIndex(e => new { e.TradegroupId, e.EffectiveDate }, "IX_tblTradeGroupRates").IsUnique();

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dbwage).HasColumnName("DBWage");
            entity.Property(e => e.DbwageDle).HasColumnName("DBWageDLE");
            entity.Property(e => e.DbwageWkend).HasColumnName("DBWageWkend");
            entity.Property(e => e.DbwageWkendDle).HasColumnName("DBWageWkendDLE");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.HourOtimeWkdayDle).HasColumnName("HourOtimeWkdayDLE");
            entity.Property(e => e.HourOtimeWkendDle).HasColumnName("HourOtimeWkendDLE");
            entity.Property(e => e.Nawkday).HasColumnName("NAWkday");
            entity.Property(e => e.NawkdayDle).HasColumnName("NAWkdayDLE");
            entity.Property(e => e.Nawkend).HasColumnName("NAWkend");
            entity.Property(e => e.NawkendDle).HasColumnName("NAWkendDLE");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.UpdateStatus).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTradeType>(entity =>
        {
            entity.HasKey(e => e.TradetypeId);

            entity.ToTable("tblTradeType");

            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.GphaJobId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_JobId");
            entity.Property(e => e.Prefixname)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("prefixname");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Trnote)
                .HasColumnType("ntext")
                .HasColumnName("TRNOTE");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users");

            entity.ToTable("tblUsers");

            entity.HasIndex(e => e.Username, "IX_Users").IsUnique();

            entity.HasIndex(e => e.UserKey, "IX_tblUsers").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo).HasMaxLength(20);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PostType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserKey)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword).HasMaxLength(20);
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Userroles).IsUnicode(false);
        });

        modelBuilder.Entity<TblUserRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("tblUserRoles");

            entity.HasIndex(e => e.UserRole, "IX_tblUserRoles").IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserRole)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblVessel>(entity =>
        {
            entity.HasKey(e => e.VesselId);

            entity.ToTable("tblVessel");

            entity.HasIndex(e => e.VesselName, "IX_tblVessel").IsUnique();

            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblWorker>(entity =>
        {
            entity.HasKey(e => e.WorkerId).HasName("PK_workers");

            entity.ToTable("tblWorkers");

            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Addr1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Addr2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AutoID");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContPer)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contaddr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.GangId).HasColumnName("GangID");
            entity.Property(e => e.Height).HasMaxLength(10);
            entity.Property(e => e.Kin)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KinAddr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KinAddrPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.NationalityId).HasColumnName("nationalityID");
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.OfficialComm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OnlinePush).HasDefaultValue(false);
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pics).HasColumnType("image");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Relation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShoeSize).HasMaxLength(10);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.Subheader)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subheader");
            entity.Property(e => e.Tin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.Who)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WHO");
            entity.Property(e => e.Whotime)
                .HasColumnType("datetime")
                .HasColumnName("WHOtime");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblWorkersIdcard>(entity =>
        {
            entity.HasKey(e => e.WorkerId);

            entity.ToTable("tblWorkersIDCard");

            entity.Property(e => e.WorkerId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAllocationBatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAllocationBatch");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkShift)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAllocationSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAllocationSheet");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkShift)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwAllocationWorker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAllocationWorkers");

            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwBankBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBankBranches");

            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDailyActiveVessel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyActiveVessel");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDailyActiveWorker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyActiveWorkers");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyActiveWorkerRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyActiveWorkerRecord");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyApproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyApproved");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.Dbwage).HasColumnName("DBWage");
            entity.Property(e => e.DbwageWkend).HasColumnName("DBWageWkend");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nawkday).HasColumnName("NAWkday");
            entity.Property(e => e.Nawkend).HasColumnName("NAWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyApprovedCostSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyApprovedCostSheet");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwDailyCostSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyCostSheet");

            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyInvoice");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GphaRequestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_RequestID");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyInvoiceStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyInvoice_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyLeaveBonu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyLeaveBonus");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyPayroll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyPayroll");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwDailyPf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyPF");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyProcessed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyProcessed");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GphaRequestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_RequestID");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyReportCasting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyReportCasting");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyReportListing>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyReportListing");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyReportListingDisapproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyReportListing_Disapproved");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyReportListingStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyReportListing_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyReq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyReq");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GphaRequestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_RequestID");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDailySsf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailySSF");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailySsfApproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailySSF_Approved");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailySsfContributor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailySSF_Contributors");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailySsfNonContributor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailySSF_NonContributors");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyStatistics");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyStatisticsStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyStatistics_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NightRateDle).HasColumnName("NightRateDLE");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OvertimeRateDle).HasColumnName("OvertimeRateDLE");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwDailyTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDailyTax");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.CargoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwLabourAdvice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLabourAdvice");

            entity.Property(e => e.AdviceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.LabourType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerName)
                .HasMaxLength(81)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwLabourAdviceDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLabourAdviceDays");

            entity.Property(e => e.AdviceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.HrsFrom).HasPrecision(0);
            entity.Property(e => e.HrsTo).HasPrecision(0);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLoans");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LoanDate).HasColumnType("datetime");
            entity.Property(e => e.LoanNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoanScheme)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WorkerName)
                .HasMaxLength(81)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwLoanRepayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLoanRepayments");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.LoanDate).HasColumnType("datetime");
            entity.Property(e => e.LoanNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoanScheme)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RepayDate).HasColumnType("datetime");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WorkerName)
                .HasMaxLength(81)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyApprovedCostSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyApprovedCostSheet");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LoanNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoanScheme)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyBankPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyBankPayment");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyInvoice");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyInvoiceStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyInvoice_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyLeaveBonu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyLeaveBonus");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwMonthlyLeaveBonusPaySlip>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyLeaveBonusPaySlip");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerName)
                .HasMaxLength(132)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyPayroll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyPayroll");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyPf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyPF");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwMonthlyPreviewCostSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyPreviewCostSheet");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyProcessed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyProcessed");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Tgno)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TGNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyReportListing>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyReportListing");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyReportListingDisapproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyReportListing_Disapproved");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyReportListingPreview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyReportListingPreview");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyReportListingStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyReportListing_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyReq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyReq");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerName)
                .HasMaxLength(132)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlySsf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlySSF");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwMonthlyStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyStatistics");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyStatisticsStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyStatistics_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMonthlyTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonthlyTax");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.OtwkdayRate).HasColumnName("OTWkdayRate");
            entity.Property(e => e.OtwkendRate).HasColumnName("OTWkendRate");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStaffMreqGangRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStaffMReqGangRates");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.Dbwage).HasColumnName("DBWage");
            entity.Property(e => e.DbwageDle).HasColumnName("DBWageDLE");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.Dtotal).HasColumnName("DTotal");
            entity.Property(e => e.Dwkday).HasColumnName("DWkday");
            entity.Property(e => e.Dwkend).HasColumnName("DWkend");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.HourOtimeWkdayDle).HasColumnName("HourOtimeWkdayDLE");
            entity.Property(e => e.HourOtimeWkendDle).HasColumnName("HourOtimeWkendDLE");
            entity.Property(e => e.Hrwkday).HasColumnName("HRWkday");
            entity.Property(e => e.Hrwkend).HasColumnName("HRWkend");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Nwkday).HasColumnName("NWkday");
            entity.Property(e => e.Nwkend).HasColumnName("NWkend");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEnd).HasColumnType("datetime");
            entity.Property(e => e.PeriodStart).HasColumnType("datetime");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStaffWreqGangRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStaffWReqGangRates");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.Dbwage).HasColumnName("DBWage");
            entity.Property(e => e.DbwageDle).HasColumnName("DBWageDLE");
            entity.Property(e => e.DbwageWkend).HasColumnName("DBWageWkend");
            entity.Property(e => e.DbwageWkendDle).HasColumnName("DBWageWkendDLE");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.HourOtimeWkdayDle).HasColumnName("HourOtimeWkdayDLE");
            entity.Property(e => e.HourOtimeWkendDle).HasColumnName("HourOtimeWkendDLE");
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Nawkday).HasColumnName("NAWkday");
            entity.Property(e => e.NawkdayDle).HasColumnName("NAWkdayDLE");
            entity.Property(e => e.Nawkend).HasColumnName("NAWkend");
            entity.Property(e => e.NawkendDle).HasColumnName("NAWkendDLE");
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportpointId).HasColumnName("ReportpointID");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwSubStaffReq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubStaffReq");

            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwSubStaffReqGangRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubStaffReqGangRates");

            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dbwage).HasColumnName("DBWage");
            entity.Property(e => e.DbwageDle).HasColumnName("DBWageDLE");
            entity.Property(e => e.DbwageWkend).HasColumnName("DBWageWkend");
            entity.Property(e => e.DbwageWkendDle).HasColumnName("DBWageWkendDLE");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.HourOtimeWkdayDle).HasColumnName("HourOtimeWkdayDLE");
            entity.Property(e => e.HourOtimeWkendDle).HasColumnName("HourOtimeWkendDLE");
            entity.Property(e => e.Nawkday).HasColumnName("NAWkday");
            entity.Property(e => e.NawkdayDle).HasColumnName("NAWkdayDLE");
            entity.Property(e => e.Nawkend).HasColumnName("NAWkend");
            entity.Property(e => e.NawkendDle).HasColumnName("NAWkendDLE");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("transport");
            entity.Property(e => e.TransportRateAmt).HasColumnName("TransportRate_Amt");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwSubStaffWreq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubStaffWReq");

            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VesselberthId).HasColumnName("VesselberthID");
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTblWorker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTblWorkers");

            entity.Property(e => e.Addr1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Addr2)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContPer)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contaddr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.GangId).HasColumnName("GangID");
            entity.Property(e => e.GphaGroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_GroupId");
            entity.Property(e => e.GphaJobId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPHA_JobId");
            entity.Property(e => e.Height).HasMaxLength(10);
            entity.Property(e => e.Kin)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KinAddr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KinAddrPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.NationalityId).HasColumnName("nationalityID");
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.OfficialComm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pics).HasColumnType("image");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Relation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShoeSize).HasMaxLength(10);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.Subheader)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subheader");
            entity.Property(e => e.Tin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.Who)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WHO");
            entity.Property(e => e.Whotime)
                .HasColumnType("datetime")
                .HasColumnName("WHOtime");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwTradeType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTradeType");

            entity.Property(e => e.Prefixname)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("prefixname");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Trnote)
                .HasColumnType("ntext")
                .HasColumnName("TRNOTE");
        });

        modelBuilder.Entity<VwWeeklyActiveVessel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyActiveVessel");

            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwWeeklyActiveWorker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyActiveWorkers");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyActiveWorkerRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyActiveWorkerRecord");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyApproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyApproved");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Dbwage).HasColumnName("DBWage");
            entity.Property(e => e.DbwageWkend).HasColumnName("DBWageWkend");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Nawkday).HasColumnName("NAWkday");
            entity.Property(e => e.Nawkend).HasColumnName("NAWkend");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyApprovedCostSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyApprovedCostSheet");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyCostSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyCostSheet");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyInvoice");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyInvoiceStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyInvoice_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyLeaveBonu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyLeaveBonus");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyPayroll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyPayroll");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyPf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyPF");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyProcessed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyProcessed");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Holiday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.Preparedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyReportListing>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyReportListing");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BankNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyReportListingDisapproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyReportListing_Disapproved");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyReportListingStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyReportListing_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyReq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyReq");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerName)
                .HasMaxLength(132)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwWeeklySsf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklySSF");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklySsfApproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklySSF_Approved");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklySsfContributor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklySSF_Contributors");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklySsfNonContributor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklySSF_NonContributors");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyStatistics");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyStatisticsStored>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyStatistics_Stored");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.BasicRateDle).HasColumnName("BasicRateDLE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date_");
            entity.Property(e => e.DlecodeCompanyId).HasColumnName("DLEcodeCompanyID");
            entity.Property(e => e.DlecodeCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcodeCompanyName");
            entity.Property(e => e.DlecompanyStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLEcompanyStatus");
            entity.Property(e => e.Nhil).HasColumnName("NHIL");
            entity.Property(e => e.Night)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ppemedical).HasColumnName("PPEMedical");
            entity.Property(e => e.PremiumWithoutTt).HasColumnName("PremiumWithoutTT");
            entity.Property(e => e.ReportingPoint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployer).HasColumnName("SSFemployer");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VesselName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWeeklyTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWeeklyTax");

            entity.Property(e => e.Adate).HasColumnType("datetime");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfemployee).HasColumnName("SSFemployee");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.Transport)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Weekends)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
        });

        modelBuilder.Entity<VwWorker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkers");

            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kin)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.SortCode)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerStatus)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwWorkerDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerDetails");

            entity.Property(e => e.Addr1)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kin)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sex)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupId).HasColumnName("TradegroupID");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeId).HasColumnName("TradetypeID");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwWorkerDetailsReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerDetails_Report");

            entity.Property(e => e.Address)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContPer)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contaddr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.GangName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Height).HasMaxLength(10);
            entity.Property(e => e.Kin)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KinAddr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KinAddrPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.OfficialComm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pics).HasColumnType("image");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Relation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ShoeSize).HasMaxLength(10);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwWorkerList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerList");

            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwWorkerListTagged>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerList_Tagged");

            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwWorkerListUntagged>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerList_Untagged");

            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Ezwichid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ezwichid");
            entity.Property(e => e.Flags)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.Nat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAT");
            entity.Property(e => e.Nhis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NHIS");
            entity.Property(e => e.Oname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Ssfno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SSFNo");
            entity.Property(e => e.TradegroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradegroupNAME");
            entity.Property(e => e.TradetypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradetypeNAME");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WorkerID");
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwWorkersIdcard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkersIDCard");

            entity.Property(e => e.DateBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_Birth");
            entity.Property(e => e.Pics).HasColumnType("image");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WorkerName)
                .HasMaxLength(132)
                .IsUnicode(false);
            entity.Property(e => e.WorkerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
