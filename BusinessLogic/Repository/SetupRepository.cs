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
    public class SetupRepository : ISetupRepository
    {
        private readonly ISqlDataAccess _db;
        public SetupRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<int> AddGang(TblGang model) => await _db.SaveData(query: "Insert into tblGangs(GangName,Notes) values(@GangName,@Notes)", new { model.GangName, model.Notes });
        public async Task<IEnumerable<TblGang>> GetAllGangs() => await _db.LoadData<TblGang, dynamic>(query: "Select * from tblGangs", new { });
        public async Task<int> RemoveGang(int Id) => await _db.SaveData(query: "Delete from tblGangs where GangId=@GangId", new { GangId = Id });
        public async Task<int> UpdateGang(TblGang model) => await _db.SaveData(query: "Update tblGangs set GangName=@GangName, Notes=@Notes where GangId=@GangId", new { model.GangId, model.GangName, model.Notes });
        public async Task<int> AddVessel(TblVessel model) => await _db.SaveData(query: "Insert into tblVessel(VesselName) values(@GangName)", new { model.VesselName });
        public async Task<IEnumerable<TblVessel>> GetAllVessels() => await _db.LoadData<TblVessel, dynamic>(query: "Select * from tblVessel", new { });
        public async Task<int> RemoveVessel(int Id) => await _db.SaveData(query: "Delete from tblVessel where VesselId=@VesselId", new { VesselId = Id });
        public async Task<int> UpdateVessel(TblVessel model) => await _db.SaveData(query: "Update tblVessel set VesselName=@VesselName where VesselId=@VesselId", new { model.VesselId, model.VesselName });
    }
}
