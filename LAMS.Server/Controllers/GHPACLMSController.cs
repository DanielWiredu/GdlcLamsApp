using AppModels;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace LAMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GHPACLMSController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GHPACLMSController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost("CreateLabourRequest")]
        public async Task<IActionResult> CreateLabourRequest([FromBody] GPHACreateLabourRequest request)
        {
            var connectionString = _configuration.GetConnectionString("Default");

            await using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            await using var transaction = await connection.BeginTransactionAsync();

            try
            {
                var labourRequestSql = @"
                INSERT INTO GPHALabourRequests
                (Id, RequestDate, LabourRequestId, UnitDescription, JobDescription, NumberRequested, NeededOn, RequestId, CompanySecret, CompanyKey, GeoLocation, WeekType, Shift)
                VALUES
                (@Id, @RequestDate, @LabourRequestId, @UnitDescription, @JobDescription, @NumberRequested, @NeededOn, @RequestId, @CompanySecret, @CompanyKey, @GeoLocation, @WeekType, @Shift)";

                await connection.ExecuteAsync(labourRequestSql, request,  transaction);

                await transaction.CommitAsync();

                return Ok(new { Message = "Labour request created successfully", LabourRequestId = request.LabourRequestId });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, new { Error = ex.Message });
            }
        }

        [HttpPost("CreateCostSheet")]
        public async Task<IActionResult> CreateCostSheet([FromBody] GPHACreateCostSheetRequest request)
        {
            var connectionString = _configuration.GetConnectionString("Default");

            await using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            await using var transaction = await connection.BeginTransactionAsync();

            try
            {
                // 1️ Insert JobAssignment
                var jobAssignmentSql = @"
                INSERT INTO GPHAJobAssignments
                (Id, NumberToSupply, Job, CostSheetId, NeededOn, Shift, DayType,
                 GeoLocation, Unit, RequestNumber, DateAdded, NumberToSupplied)
                VALUES
                (@Id, @NumberToSupply, @Job, @CostSheetId, @NeededOn, @Shift, @DayType,
                 @GeoLocation, @Unit, @RequestNumber, @DateAdded, @NumberToSupplied)";

                await connection.ExecuteAsync(
                    jobAssignmentSql,
                    request.JobAssignment,
                    transaction
                );

                // 2️ Insert CostSheet
                var costSheetId = Guid.NewGuid();

                var costSheetSql = @"
                INSERT INTO GPHACostSheets
                (Id, JobAssignmentId, LabourCompany, CompanyId, TotalAmount,
                 GeneratedDate, Status, Shift, CostSheetNumber,
                 DateAdded, PaymentReference, PaymentStatus)
                VALUES
                (@Id, @JobAssignmentId, @LabourCompany, @CompanyId, @TotalAmount,
                 @GeneratedDate, @Status, @Shift, @CostSheetNumber,
                 @DateAdded, @PaymentReference, @PaymentStatus)";

                await connection.ExecuteAsync(
                    costSheetSql,
                    new
                    {
                        Id = costSheetId,
                        JobAssignmentId = request.JobAssignment.Id,
                        request.CostSheet.LabourCompany,
                        request.CostSheet.CompanyId,
                        request.CostSheet.TotalAmount,
                        request.CostSheet.GeneratedDate,
                        request.CostSheet.Status,
                        request.CostSheet.Shift,
                        request.CostSheet.CostSheetNumber,
                        request.CostSheet.DateAdded,
                        request.CostSheet.PaymentReference,
                        request.CostSheet.PaymentStatus
                    },
                    transaction
                );

                // 3️ Insert CostSheetDetails (bulk)
                var detailSql = @"
                INSERT INTO GPHACostSheetDetails
                (Id, CostSheetId, DateAdded, Audited, AuditedDate, RateType,
                 HoursWorked, BaseRate, PremiumTotal, NHilGflTotal, VatTotal,
                 TransportationTotal, IncentiveTotal, Level, JobDescription,
                 Worker, WorkerId, Company, ShiftAllowance, NightAllowance,
                 Total, Unit, AuditedBy, OverTimeHours, OverTimeRate, GroupIncentive)
                VALUES
                (@Id, @CostSheetId, @DateAdded, @Audited, @AuditedDate, @RateType,
                 @HoursWorked, @BaseRate, @PremiumTotal, @NHilGflTotal, @VatTotal,
                 @TransportationTotal, @IncentiveTotal, @Level, @JobDescription,
                 @Worker, @WorkerId, @Company, @ShiftAllowance, @NightAllowance,
                 @Total, @Unit, @AuditedBy, @OverTimeHours, @OverTimeRate, @GroupIncentive)";

                var details = request.CostSheetDetails.Select(d => new
                {
                    d.Id,
                    CostSheetId = costSheetId,
                    d.DateAdded,
                    d.Audited,
                    d.AuditedDate,
                    d.RateType,
                    d.HoursWorked,
                    d.BaseRate,
                    d.PremiumTotal,
                    d.NHilGflTotal,
                    d.VatTotal,
                    d.TransportationTotal,
                    d.IncentiveTotal,
                    d.Level,
                    d.JobDescription,
                    d.Worker,
                    d.WorkerId,
                    d.Company,
                    d.ShiftAllowance,
                    d.NightAllowance,
                    d.Total,
                    d.Unit,
                    d.AuditedBy,
                    d.OverTimeHours,
                    d.OverTimeRate,
                    d.GroupIncentive
                });

                await connection.ExecuteAsync(detailSql, details, transaction);

                await transaction.CommitAsync();

                return Ok(new { Message = "Cost sheet created successfully", CostSheetId = costSheetId });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, new { Error = ex.Message });
            }
        }
    }
}
