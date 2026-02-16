using AppModels;
using DataAccess.Models;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Net;
using System.Net.Http.Headers;

namespace AppMain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilitiesController : Controller
    {


        private readonly GdlcdbContext _context;
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        private readonly IBackgroundJobClient _jobClient;
        private readonly IRecurringJobManager _jobManager;

        private readonly string clmsUrl;
        private readonly string userId;
        private readonly string companyID;
        private readonly string userPassword;

        private readonly string sync_backhours;
        private readonly string sync_records;
        private readonly string sync_request_backmins;

        private readonly string GdlcBranch;
        public UtilitiesController(GdlcdbContext context, HttpClient client, IConfiguration config, IBackgroundJobClient jobClient, IRecurringJobManager jobManager)
        {
            _context = context;
            _config = config;
            
            _jobClient = jobClient;
            _jobManager = jobManager;

            clmsUrl = _config.GetSection("CLMSSyncSettings:gphaClms_Url").Value!;
            userId = _config.GetSection("CLMSSyncSettings:gphaClms_UserID").Value!;
            companyID = _config.GetSection("CLMSSyncSettings:gphaClms_CompanyID").Value!;
            userPassword = _config.GetSection("CLMSSyncSettings:gphaClms_UserPassword").Value!;

            sync_backhours = _config.GetSection("CLMSSyncSettings:sync_backhours").Value!;
            sync_records = _config.GetSection("CLMSSyncSettings:sync_records").Value!;
            sync_request_backmins = _config.GetSection("CLMSSyncSettings:sync_request_backmins").Value!;

            GdlcBranch = _config.GetSection("GdlcBranch").Value!;

            _client = client;
            _client.BaseAddress = new Uri(clmsUrl);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("SyncGPHACostSheets")]
        public async Task<string> GetGPHACostSheets()
        {
            var now = DateTime.UtcNow.TimeOfDay;
            var mainWindow = now >= new TimeSpan(6, 0, 0) && now < new TimeSpan(18, 0, 0);
            var lunchWindow = now >= new TimeSpan(11, 30, 0) && now < new TimeSpan(13, 30, 0);
            if (mainWindow && !lunchWindow /* && !otherWindow */)
            {
                return "GPHA API is not configured to run at this time";
            }
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            string workerId = "";
            int tradeGroupId = 0;
            int isync_backhours = Int32.Parse(sync_backhours);
            int isync_records = Int32.Parse(sync_records);

            //var _costsheets = context.tblGPHA_LabourRequests.Where(x => x.hasCostSheet == true && x.GPHA_Approved == false).OrderBy(x => x.Id).Take(100);
            DateTime sync_upto = DateTime.UtcNow.AddHours(-isync_backhours);
            DateTime lastQuarter = DateTime.UtcNow.AddMonths(-3);
            //var _costsheets = context.tblGPHA_LabourRequests.Where(x => x.hasCostSheet == true && x.GPHA_Approved == false).Select(i => new { i.LabourRequestID }).Distinct().OrderByDescending(x => x.LabourRequestID).Take(30);
            var _costsheets = _context.TblGphaLabourRequests.AsNoTracking().Where(x => x.HasCostSheet == true && x.GphaApproved == false && x.SyncDate <= sync_upto && x.RequestDate >= lastQuarter).OrderBy(x => x.SyncDate).Select(i => new { i.LabourRequestId }).Distinct().Take(isync_records).ToList();

            foreach (var request in _costsheets)
            {
                //LogEvents.LogToFile("Costsheet Data", request.LabourRequestID);
                #region approveCostSheets
                try
                {
                    //var gdlcRequest = context.tblGPHA_LabourRequests.FirstOrDefault(x => x.LabourRequestID == request.LabourRequestID && x.GPHA_Approved == false);
                    var gdlcRequest = await _context.TblGphaLabourRequests.OrderBy(x => x.SyncDate).FirstOrDefaultAsync(x => x.LabourRequestId == request.LabourRequestId && x.GphaApproved == false);
                    if (gdlcRequest == null)
                        continue;

                    //move to the next request if same request ID is already approved -- handles duplicate request IDs for different trades --
                    if (_context.TblGphaLabourRequests.Any(x => x.LabourRequestId == request.LabourRequestId && x.GphaApproved == true))
                    {
                        gdlcRequest.GphaApproved = true;
                        gdlcRequest.SyncDate = DateTime.UtcNow;
                        continue;
                    }
                    //move to the next request if same request ID is already approved -- handles duplicate request IDs for different trades --

                    //
                    string reqno = gdlcRequest.CostSheetNo;
                    if (_context.TblStaffReqs.Any(x => x.ReqNo == reqno && x.Approved == true))
                    {
                        gdlcRequest.GphaApproved = true;
                        gdlcRequest.SyncDate = DateTime.UtcNow;
                        continue;
                    }
                    //

                    var data = await _client.GetStringAsync(
                    _client.BaseAddress + "api/get_costsheet.php?userid="
                           + userId + "&companyid=" + companyID + "&userpassword=" + userPassword + "&requestid=" + request.LabourRequestId);

                    var _requests = (GPHACostSheetModel)JsonConvert.DeserializeObject(data, typeof(GPHACostSheetModel));

                    //
                    if (_requests.RequestDetails.Count == 0) //if not in pending, check from approved/completed cost sheets
                    {
                        data = await _client.GetStringAsync(
                        _client.BaseAddress + "/api/get_processed_costsheet.php?userid="
                              + userId + "&companyid=" + companyID + "&userpassword=" + userPassword + "&requestid=" + request.LabourRequestId);

                        _requests = (GPHACostSheetModel)JsonConvert.DeserializeObject(data, typeof(GPHACostSheetModel));
                    }
                    //

                    if (_requests.RequestDetails.Count == 0)
                    {
                        gdlcRequest.SyncDate = DateTime.UtcNow;
                        continue;
                    }

                    var staffReq = await _context.TblStaffReqs.FirstOrDefaultAsync(x => x.ReqNo == reqno);

                    if (staffReq == null)
                        continue;

                    var _workerList = _requests.RequestDetails.Where(x => x.LabourRequestID == request.LabourRequestId).ToList();

                    foreach (var _worker in _workerList)
                    {
                        if (_worker.HoursWorked == 0)
                            continue;

                        if (staffReq.Normal == 0 || String.IsNullOrEmpty(staffReq.GphaRequestId))
                        {
                            staffReq.Normal = _worker.HoursWorked;
                            staffReq.Overtime = string.IsNullOrEmpty(_worker.OvertimeHours) ? 0 : Convert.ToDouble(_worker.OvertimeHours);
                            staffReq.GphaRequestId = request.LabourRequestId;

                            //context.SaveChanges();
                        }

                        var authArr = _worker.Worker.Split(new Char[] { '[', ']' });
                        if (authArr.Length == 5)
                            workerId = authArr[3].ToString();
                        else if (authArr.Length == 3)
                            workerId = authArr[1].ToString();
                        else
                            continue;

                        var gdlcWorker = await _context.TblWorkers.FirstOrDefaultAsync(x => x.WorkerId == workerId);
                        if (gdlcWorker == null)
                            continue;

                        tradeGroupId = gdlcWorker.TradegroupId.Value;

                        if (!_context.TblSubStaffReqs.Any(x => x.ReqNo == reqno && x.WorkerId == workerId))
                        {
                            var _subStaffReq = new TblSubStaffReq
                            {
                                ReqNo = reqno,
                                WorkerId = workerId,
                                TradegroupId = tradeGroupId,
                                Transport = "*",
                                Normal = _worker.HoursWorked,
                                Overtime = string.IsNullOrEmpty(_worker.OvertimeHours) ? 0 : Convert.ToDouble(_worker.OvertimeHours)
                            };
                            _context.TblSubStaffReqs.Add(_subStaffReq);
                        }
                    }

                    gdlcRequest.GphaApproved = true;
                    gdlcRequest.GphaApprovedDate = DateTime.UtcNow;
                    gdlcRequest.SyncDate = DateTime.UtcNow;
                }
                catch (Exception ex)
                {
                    //LogEvents.LogToFile("Costsheet Data - Error", ex.Message.Replace("'", "").Replace("\r\n", ""));
                    return ex.Message.Replace("'", "").Replace("\r\n", "");
                }

                #endregion approveCostSheets

                //context.SaveChanges();
            }

            await _context.SaveChangesAsync();

            return "Cost Sheet Sync Done";
        }
        [HttpGet("SyncGPHALabourRequests")]
        public async Task<string> GetGPHALabourRequests()
        {
            var now = DateTime.UtcNow.TimeOfDay;
            var mainWindow = now >= new TimeSpan(6, 0, 0) && now < new TimeSpan(18, 0, 0);
            var lunchWindow = now >= new TimeSpan(11, 30, 0) && now < new TimeSpan(13, 30, 0);
            if (mainWindow && !lunchWindow /* && !otherWindow */)
            {
                return "GPHA API is not configured to run at this time";
            }
            try
            {
                int sync_mins = Math.Abs(Convert.ToInt32(sync_request_backmins));
                if (sync_mins == 0)
                {
                    var lastRequest = await _context.TblGphaLabourRequests.OrderByDescending(x => x.RequestDate).FirstOrDefaultAsync();
                    if (lastRequest != null)
                    {
                        TimeSpan ts = DateTime.UtcNow - lastRequest.RequestDate.Value;
                        sync_mins = Convert.ToInt32(ts.TotalMinutes) + 240; //allow extra 4 hours for contigencies
                    }
                }

                //LogEvents.LogToFile("Request Data", gphaclient.BaseAddress + "api/get_labour_request_by_minutes.php?userid=" + userId + "&companyid=" + companyID + "&userpassword=" + userPassword + "&min=" + sync_mins.ToString());

                //var data = await gphaclient.GetStringAsync(
                //               gphaclient.BaseAddress + "/api/get_labour_request.php?userid="
                //               + userId + "&companyid=" + companyID + "&userpassword=" + userPassword);
                var data = await _client.GetStringAsync(
                _client.BaseAddress + "api/get_labour_request_by_minutes.php?userid="
                               + userId + "&companyid=" + companyID + "&userpassword=" + userPassword + "&min=" + sync_mins.ToString());



                var _requests = (GPHALabourRequestModel)JsonConvert.DeserializeObject(data, typeof(GPHALabourRequestModel));

                //foreach (var item in _requests.RequestDetails.Where(x => x.RequestDate >= DateTime.UtcNow.AddHours(-24)))
                foreach (var item in _requests.RequestDetails.OrderBy(x => x.RequestDate))
                {
                    //LogEvents.LogToFile("Request Data", item.LabourRequestID + "-" + item.RequestDate);

                    if (!_context.TblGphaLabourRequests.Any(x => x.LabourRequestId == item.LabourRequestID && x.JobRequested == item.JobRequested))
                    {
                        var authArr = item.NeededOn.Split(new Char[] { '[', ']' });

                        var _request = new TblGphaLabourRequest
                        {
                            RequestDate = item.RequestDate,
                            LabourRequestId = item.LabourRequestID,
                            UnitDescription = item.UnitDescription,
                            JobRequested = item.JobRequested,
                            NumberRequested = item.NumberRequested,
                            NeededOn = item.NeededOn,

                            RNeededOn = Convert.ToDateTime(authArr[0].ToString()),
                            RDay = authArr[1].ToString(),
                            RShift = authArr[3].ToString(),
                            CreatedDate = DateTime.UtcNow,
                            HasCostSheet = false,
                            GphaApproved = false,
                            SyncDate = DateTime.UtcNow
                        };

                        _context.TblGphaLabourRequests.Add(_request);
                    }
                }

                await _context.SaveChangesAsync();
                return "Labour Request Sync Done";
            }
            catch (Exception ex)
            {
                //LogEvents.LogToFile("Request Data - Error", ex.InnerException.Message.Replace("'", "").Replace("\r\n", ""));
                return ex.Message.Replace("'", "").Replace("\r\n", "");
            }
        }
        [HttpGet("SyncGPHARequestCostSheet/{LabourRequestID}")]
        public async Task<string> GetGPHARequestCostSheet(string LabourRequestID)
        {
            var now = DateTime.UtcNow.TimeOfDay;
            if (now >= new TimeSpan(6, 0, 0) && now < new TimeSpan(20, 0, 0))
            {
                return "GPHA API is not configured to run between 6 AM and 8 PM.";
            }

            string workerId = "";
            int tradeGroupId = 0;

            #region approveCostSheets
            try
            {
                var gdlcRequest = await _context.TblGphaLabourRequests.FirstOrDefaultAsync(x => x.LabourRequestId == LabourRequestID && x.GphaApproved == false);
                if (gdlcRequest == null)
                    return "No Data Found";

                //move to the next request if same request ID is already approved -- handles duplicate request IDs for different trades --
                if (_context.TblGphaLabourRequests.Any(x => x.LabourRequestId == LabourRequestID && x.GphaApproved == true))
                {
                    gdlcRequest.SyncDate = DateTime.UtcNow;
                    gdlcRequest.GphaApproved = true;
                    _context.SaveChanges();
                    return "RequestID Already Approved";
                }
                //move to the next request if same request ID is already approved -- handles duplicate request IDs for different trades --

                //
                string reqno = gdlcRequest.CostSheetNo;
                if (_context.TblStaffReqs.Any(x => x.ReqNo == reqno && x.Approved == true))
                {
                    gdlcRequest.SyncDate = DateTime.UtcNow;
                    gdlcRequest.GphaApproved = true;
                    _context.SaveChanges();
                    return "Cost Sheet Already Approved";
                }
                //

                var data = await _client.GetStringAsync(
                _client.BaseAddress + "api/get_costsheet.php?userid="
                       + userId + "&companyid=" + companyID + "&userpassword=" + userPassword + "&requestid=" + LabourRequestID);

                var _requests = (GPHACostSheetModel)JsonConvert.DeserializeObject(data, typeof(GPHACostSheetModel));

                //
                if (_requests.RequestDetails.Count == 0) //if not in pending, check from approved/completed cost sheets
                {
                    data = await _client.GetStringAsync(
                    _client.BaseAddress + "api/get_processed_costsheet.php?userid="
                          + userId + "&companyid=" + companyID + "&userpassword=" + userPassword + "&requestid=" + LabourRequestID);

                    _requests = (GPHACostSheetModel)JsonConvert.DeserializeObject(data, typeof(GPHACostSheetModel));
                }
                //

                if (_requests.RequestDetails.Count == 0)
                {
                    gdlcRequest.SyncDate = DateTime.UtcNow;
                    await _context.SaveChangesAsync();
                    return "Not Approved on GPHA CLMS";
                }

                var staffReq = await _context.TblStaffReqs.FirstOrDefaultAsync(x => x.ReqNo == reqno);

                if (staffReq == null)
                {
                    gdlcRequest.SyncDate = DateTime.UtcNow;
                    await _context.SaveChangesAsync();
                    return "Cost Sheet Not Found";
                }

                var _workerList = _requests.RequestDetails.Where(x => x.LabourRequestID == LabourRequestID).ToList();

                foreach (var _worker in _workerList)
                {
                    if (staffReq.Normal == 0 || String.IsNullOrEmpty(staffReq.GphaRequestId))
                    {
                        staffReq.Normal = _worker.HoursWorked;
                        staffReq.Overtime = string.IsNullOrEmpty(_worker.OvertimeHours) ? 0 : Convert.ToDouble(_worker.OvertimeHours);
                        staffReq.GphaRequestId = LabourRequestID;

                        //context.SaveChanges();
                    }

                    var authArr = _worker.Worker.Split(new Char[] { '[', ']' });
                    if (authArr.Length == 5)
                        workerId = authArr[3].ToString();
                    else if (authArr.Length == 3)
                        workerId = authArr[1].ToString();
                    else
                        continue;

                    var gdlcWorker = await _context.TblWorkers.FirstOrDefaultAsync(x => x.WorkerId == workerId);
                    if (gdlcWorker == null)
                        continue;

                    tradeGroupId = gdlcWorker.TradegroupId.Value;

                    if (!_context.TblSubStaffReqs.Any(x => x.ReqNo == reqno && x.WorkerId == workerId))
                    {
                        var _subStaffReq = new TblSubStaffReq
                        {
                            ReqNo = reqno,
                            WorkerId = workerId,
                            TradegroupId = tradeGroupId,
                            Transport = "*",
                            Normal = _worker.HoursWorked,
                            Overtime = string.IsNullOrEmpty(_worker.OvertimeHours) ? 0 : Convert.ToDouble(_worker.OvertimeHours)
                        };
                        _context.TblSubStaffReqs.Add(_subStaffReq);
                    }
                }

                gdlcRequest.GphaApproved = true;
                gdlcRequest.GphaApprovedDate = DateTime.UtcNow;
                gdlcRequest.SyncDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();

                return "Request Sync Completed";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            #endregion approveCostSheets

            //return "Request Sync Completed";
        }

        [HttpGet("ScheduleCLMSSyncs")]
        public IResult ScheduleCLMSSyncs()
        {
            try
            {
                _jobManager.AddOrUpdate<UtilitiesController>($"GetGPHARequests_{GdlcBranch}", GdlcBranch, x => x.GetGPHALabourRequests(), "*/55 * * * *");

                _jobManager.AddOrUpdate<UtilitiesController>($"SyncGPHACostSheets_{GdlcBranch}", GdlcBranch, x => x.GetGPHACostSheets(), "*/7 * * * *");

                var response = $"Jobs Sent to Hangfire! at {DateTime.UtcNow}";
                return Results.Ok(response);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, SD.LogErrorMsg, null, User.Identity?.Name);
                return Results.Problem();
            }
        }

        [HttpPost("CreateRequest")]
        public async Task<IActionResult> CreateRequest([FromBody] LabourRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                // Ensure ID is generated if not provided
                if (request.Id == Guid.Empty)
                    request.Id = Guid.NewGuid();

                // Default request date if not supplied
                if (request.RequestDate == default)
                    request.RequestDate = DateTime.UtcNow;

                await _context.LabourRequests.AddAsync(request);
                await _context.SaveChangesAsync();

                return CreatedAtAction(
                    nameof(GetRequestById),
                    new { id = request.Id },
                    request);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, SD.LogErrorMsg, null, User.Identity?.Name);
                return BadRequest(ex.Message.Replace("'", "").Replace("\r\n", ""));
            } 
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetRequestById(Guid id)
        {
            try
            {
                var labourRequest = await _context.LabourRequests.FindAsync(id);

                if (labourRequest == null)
                    return NotFound();

                return Ok(labourRequest);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, SD.LogErrorMsg, null, User.Identity?.Name);
                return BadRequest(ex.Message.Replace("'", "").Replace("\r\n", ""));
            }  
        }
    } 
}
