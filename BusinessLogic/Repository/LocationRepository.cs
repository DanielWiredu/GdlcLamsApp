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
    public class LocationRepository : ILocationRepository
    {
        private readonly ISqlDataAccess _db;
        public LocationRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<int> Add(TblLocation model) => await _db.SaveData(query: "Insert into tblLocation(Location) values(@Location)", new {model.Location });
       

        public async Task<TblLocation> Find(string Id)
        {
            var results = await _db.LoadData<TblLocation, dynamic>(query: "Select * from tblLocation where LocationId=@LocationId", new { LocationId = int.Parse(Id) });
            return results.FirstOrDefault();
        }

        public async Task<IEnumerable<TblLocation>> GetAll() => await _db.LoadData<TblLocation, dynamic>(query: "Select * from tblLocation", new { });

        public async Task<int> Remove(string Id) => await _db.SaveData(query: "Delete from tblLocation where LocationId=@LocationId", new { LocationId = int.Parse(Id) });

        public async Task<int> Update(TblLocation model) => await _db.SaveData(query: "Update tblLocation set Location=@Location where LocationId=@LocationId", new { model.LocationId, model.Location });
    }
}
