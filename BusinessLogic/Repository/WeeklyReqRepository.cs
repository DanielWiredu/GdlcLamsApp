using BusinessLogic.Repository.IRepository;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository
{
    public class WeeklyReqRepository : IWeeklyReqRepository
    {
        private readonly ISqlDataAccess _db;
        public WeeklyReqRepository(ISqlDataAccess db)
        {
            _db = db;
        }
    }
}
