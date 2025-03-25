using BusinessLogic.Repository.IRepository;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly ISqlDataAccess _db;
        public WorkerRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<int> Add(TblWorker model) => await _db.SaveData(query: "Insert into tblLocation(Location) values(@Location)", new {model.Sname });
       

        public async Task<TblWorker> Find(string Id)
        {
            var results = await _db.LoadData<TblWorker, dynamic>(query: "Select * from tblLocation where LocationId=@LocationId", new { LocationId = int.Parse(Id) });
            return results.FirstOrDefault();
        }

        public async Task<IEnumerable<TblWorker>> GetAll() => await _db.LoadData<TblWorker, dynamic>(query: "Select top(12000) * from vwWorkers", new { });

        public async Task<int> Remove(string Id) => await _db.SaveData(query: "Delete from tblLocation where LocationId=@LocationId", new { LocationId = int.Parse(Id) });

        public async Task<int> Update(TblWorker model) => await _db.SaveData(query: "Update tblLocation set Location=@Location where LocationId=@LocationId", new { model.WorkerId, model.Sname });
    }
}
