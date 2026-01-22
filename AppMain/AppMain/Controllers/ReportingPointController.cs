using BusinessLogic.Repository.IRepository;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppMain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportingPointController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReportingPointController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<ReportingPoint>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblReportingPoint>>> Get()
        {
            var reportingPoints = await _unitOfWork.ReportingPoints.GetAll();
            return Ok(reportingPoints);
        }
    }
}
