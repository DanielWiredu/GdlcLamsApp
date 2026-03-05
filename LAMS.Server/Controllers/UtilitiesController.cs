using AppModels.DailyReq;
using BusinessLogic.Repository.IRepository;
using Hangfire;
using LAMS.Server.Components.Pages.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilitiesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBackgroundJobClient _jobClient;
        private readonly IRecurringJobManager _jobManager;
        private readonly IConfiguration _config;
        public UtilitiesController(IUnitOfWork unitOfWork, IBackgroundJobClient jobClient, IRecurringJobManager jobManager, IConfiguration config)
        {
            _unitOfWork = unitOfWork;
            _jobClient = jobClient;
            _jobManager = jobManager;
            _config = config;
        }
        [HttpPost("ProcessGPHAPendingApprovedRequests")]
        public async Task<IActionResult> ProcessGPHAPendingApprovedRequests()
        {
            var processedRequests = new List<string>();
            try
            {
                var requests = await _unitOfWork.DailyReq.GetGPHAPendingApprovedRequests();
                if (!requests.Any())
                {
                    return NotFound(new { message = "No pending approved requests found." });
                }
                foreach (var request in requests)
                {
                    var gdlcRequest = await _unitOfWork.DailyReq.GetGPHARequestByID(request.RequestNumber);
                    if (gdlcRequest == null)
                        continue;

                    string reqno = gdlcRequest.CostSheetNo;
                    var staffReq = await _unitOfWork.DailyReq.GetDailyReq(reqno);

                    if (staffReq == null || staffReq.Approved == true)
                        continue;

                    var _workerList = await _unitOfWork.DailyReq.GetGPHACostSheetDetails(request.CostSheetId.ToString());
                    foreach (var _worker in _workerList)
                    {
                        if (_worker == null || _worker.HoursWorked == 0) continue;

                        if (staffReq.Normal == 0 || String.IsNullOrEmpty(staffReq.GphaRequestId))
                        {
                            await _unitOfWork.DailyReq.UpdateDailyReqGPHAHours(new UpdateReqGPHAHoursRequest
                            {
                                Normal = Convert.ToDouble(_worker.HoursWorked),
                                Overtime = Convert.ToDouble(_worker.OverTimeHours),
                                GPHA_RequestID = gdlcRequest.LabourRequestId,
                                ReqNo = reqno
                            });

                            var gdlcWorker = await _unitOfWork.Workers.Find(_worker.WorkerId);
                            if (gdlcWorker == null)
                                continue;

                            int tradeGroupId = gdlcWorker.TradegroupId.Value;

                            await _unitOfWork.DailyReq.AddGPHASubStaff(new AddSubStaffRequest
                            {
                                ReqNo = reqno,
                                WorkerId = _worker.WorkerId,
                                TradegroupID = tradeGroupId,
                                Normal = Convert.ToDouble(_worker.HoursWorked),
                                Overtime = Convert.ToDouble(_worker.OverTimeHours)
                            });
                        }
                    }
                    processedRequests.Add(request.RequestNumber);
                }

                //update db with processed requests
                if (processedRequests.Count > 0)
                    await _unitOfWork.DailyReq.UpdateProcessedGPHARequests(processedRequests);

                return Ok(new { message = $"Processed requests: {processedRequests.Count}" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("InitiateGPHAPendingApprovedRequests")]
        public IResult InitiateGPHAPendingApprovedRequests()
        {
            try
            {
                var queueName = _config.GetSection("HangfireSettings:QueueName").Value;
                _jobManager.AddOrUpdate<UtilitiesController>($"ProcessGPHAPendingApprovedRequests_{queueName}", queueName, x => x.ProcessGPHAPendingApprovedRequests(), "*/10 * * * *");
                var response = "Initiated Process GPHAPending Approved Requests!";
                return Results.Ok(response);
            }
            catch (Exception ex)
            {
                return Results.Problem();
            }
        }
    }
}
