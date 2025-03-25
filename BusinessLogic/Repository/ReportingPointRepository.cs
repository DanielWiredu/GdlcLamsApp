using AppModels;
using AutoMapper;
using BusinessLogic.Repository.IRepository;
using Dapper;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository
{
    public class ReportingPointRepository : IReportingPointRepository
    {
        private readonly ISqlDataAccess _db;
        private readonly IMapper _mapper;
        public ReportingPointRepository(ISqlDataAccess db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<int> Add(ReportingPointModel model) => await _db.SaveData(query: "Insert into tblReportingPoint(ReportingPoint) values(@ReportingPoint)", new {model.ReportingPoint });
       

        public async Task<ReportingPointModel> Find(string Id)
        {
            IEnumerable<TblReportingPoint> results = await _db.LoadData<TblReportingPoint, dynamic>(query: "Select * from tblReportingPoint where ReportingPointId=@ReportingPointId", new { ReportingPointId = int.Parse(Id) });
            var finalResults = _mapper.Map<IEnumerable<TblReportingPoint>, IEnumerable<ReportingPointModel>>(results);
            return finalResults.FirstOrDefault();
        }

        public async Task<IEnumerable<ReportingPointModel>> GetAll() => await _db.LoadData<ReportingPointModel, dynamic>(query: "Select * from tblReportingPoint where ReportingPointId < @ReportingPointId", new { ReportingPointId = 3000});

        public async Task<int> Remove(string Id) => await _db.SaveData(query: "Delete from tblReportingPoint where ReportingPointId=@ReportingPointId", new { ReportingPointId = int.Parse(Id) });

        public async Task<int> Update(ReportingPointModel model) => await _db.SaveData(query: "Update tblReportingPoint set ReportingPoint=@ReportingPoint where ReportingPointId=@ReportingPointId", model);

        public async Task<string> isLogged(DateTime actionDate, string actionBy, string actionDescription, string actionId)
        {
            var p = new DynamicParameters();
            p.Add("@actiondate", actionDate);
            p.Add("@actionby", actionBy);
            p.Add("@actiondescription", actionDescription);
            p.Add("@actionid", actionId);
            p.Add("@actionlogged", null, dbType: DbType.String, direction: ParameterDirection.Output, 50);
            p.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "aaspAddAuditTrailDelete", p);

            var return_value = p.Get<Int32>("@return_value");
            if (return_value == 0)
            {
                var logStatus = p.Get<string>("@actionlogged");
                return logStatus;
            }
            else
            {
                return "Execution failed...";
            }
        }
    }
}
