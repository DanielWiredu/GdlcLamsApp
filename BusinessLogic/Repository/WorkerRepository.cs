using BusinessLogic.Repository.IRepository;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Buffers;
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

        public async Task<IEnumerable<VwWorker>> GetAll(string _searchValue) => await _db.LoadData<VwWorker, dynamic>(
            query: @"SELECT TOP(200) [WorkerID], [NationalID], [SName], [OName], [Date_Birth] AS DateBirth, [GangName], [SSFNo], [TradegroupNAME], [TradetypeNAME], [NHIS], [ezwichid], [RegDate], [PhoneNo], [Kin], BankNumber, [WorkerStatus] FROM [vwWorkers] 
                     WHERE WorkerID LIKE '%' + @SearchValue + '%' OR NationalID LIKE '%' + @SearchValue + '%' OR SName LIKE '%' + @SearchValue + '%' OR OName LIKE '%' + @SearchValue + '%' OR ezwichid LIKE '%' + @SearchValue + '%'", new { SearchValue = _searchValue });

        public async Task<int> Remove(string Id) => await _db.SaveData(query: "Delete from tblLocation where LocationId=@LocationId", new { LocationId = int.Parse(Id) });

        public async Task<int> Update(TblWorker model) => await _db.SaveData(query: "Update tblLocation set Location=@Location where LocationId=@LocationId", new { model.WorkerId, model.Sname });

        public async Task<IEnumerable<VwWorker>> Search(string _searchType, string _searchValue)
        {
            int searchLimit = 100;
            string query = $"SELECT top({searchLimit}) [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID] FROM [vwWorkers] WHERE WorkerID LIKE '% ' @SearchValue + '%'";
            if (_searchType == "WorkerID")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID] FROM [vwWorkers] WHERE WorkerID LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "SSFNo")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID] FROM [vwWorkers] WHERE SSFNo LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "NHISNo")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID] FROM [vwWorkers] WHERE NHIS LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "Gang")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID] FROM [vwWorkers] WHERE GangName LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "Surname")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID] FROM [vwWorkers] WHERE SName LIKE '%' + @SearchValue + '%' ORDER BY [OName]";
            else if (_searchType == "Othernames")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID] FROM [vwWorkers] WHERE OName LIKE '%' + @SearchValue + '%' ORDER BY [SName]";
            return await _db.LoadData<VwWorker, dynamic>(query: query, new { SearchValue = _searchValue });
        }
        public async Task<IEnumerable<TblTradeGroup>> GetTradeGroups()
        {
            string query = $"SELECT * FROM tblTradeGroup";
            return await _db.LoadData<TblTradeGroup, dynamic>(query: query, new { });
        }
        public async Task<IEnumerable<TblTradeType>> GetTradeTypeByGroup(int tradeGroupId)
        {
            string query = $"SELECT TradetypeID,TradetypeNAME FROM [tblTradeType] WHERE TradegroupID=@TradeGroupID";
            return await _db.LoadData<TblTradeType, dynamic>(query: query, new { TradeGroupID = tradeGroupId });
        }
    }
}
