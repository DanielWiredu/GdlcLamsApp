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
        public async Task<int> AddCargo(TblCargo model) => await _db.SaveData(query: "Insert into tblCargo(CargoName) values(@CargoName)", new { model.CargoName });
        public async Task<IEnumerable<TblCargo>> GetAllCargo() => await _db.LoadData<TblCargo, dynamic>(query: "Select * from tblCargo", new { });
        public async Task<int> RemoveCargo(int Id) => await _db.SaveData(query: "Delete from tblCargo where CargoId=@CargoId", new { CargoId = Id });
        public async Task<int> UpdateCargo(TblCargo model) => await _db.SaveData(query: "Update tblCargo set CargoName=@CargoName where CargoId=@CargoId", new { model.CargoId, model.CargoName });
        public async Task<int> AddNationality(TblNationality model) => await _db.SaveData(query: "Insert into tblNationality(Nationality) values(@Nationality)", new { model.Nationality });
        public async Task<IEnumerable<TblNationality>> GetAllNationality() => await _db.LoadData<TblNationality, dynamic>(query: "Select * from tblNationality", new { });
        public async Task<int> RemoveNationality(int Id) => await _db.SaveData(query: "Delete from tblNationality where Id=@Id", new { NationalityId = Id });
        public async Task<int> UpdateNationality(TblNationality model) => await _db.SaveData(query: "Update tblNationality set Nationality=@Nationality where Id=@Id", new { model.Id, model.Nationality });
        public async Task<int> AddBank(TblBank model) => await _db.SaveData(query: "Insert into tblBanks(BankName) values(@BankName)", new { model.BankName });
        public async Task<IEnumerable<TblBank>> GetAllBank() => await _db.LoadData<TblBank, dynamic>(query: "Select * from tblBanks", new { });
        public async Task<int> RemoveBank(int Id) => await _db.SaveData(query: "Delete from tblBanks where BankId=@BankId", new { BankId = Id });
        public async Task<int> UpdateBank(TblBank model) => await _db.SaveData(query: "Update tblBanks set BankName=@BankName where BankId=@BankId", new { model.BankId, model.BankName });
        public async Task<int> AddBankBranch(TblBankBranch model) => await _db.SaveData(query: "Insert into tblBankBranches(BranchName,BankId,SortCode) values(@BranchName, @BankId, @SortCode)", new { model.BranchName, model.BankId, model.SortCode });
        public async Task<IEnumerable<VwBankBranch>> GetAllBankBranch() => await _db.LoadData<VwBankBranch, dynamic>(query: "Select * from VwBankBranches", new { });
        public async Task<int> RemoveBankBranch(int Id) => await _db.SaveData(query: "Delete from tblBankBranches where BranchId=@BranchId", new { BranchId = Id });
        public async Task<int> UpdateBankBranch(TblBankBranch model) => await _db.SaveData(query: "Update tblBankBranches set BranchName=@BranchName,BankId=@BankId,SortCode=@SortCode where BranchId=@BranchId", new { model.BranchId, model.BranchName, model.BankId, model.SortCode });
    }
}
