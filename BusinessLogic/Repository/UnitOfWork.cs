using BusinessLogic.Repository.IRepository;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISqlDataAccess _db;
        public UnitOfWork(ISqlDataAccess db) 
        {
            _db = db;
            Location = new LocationRepository(_db);
        }
        public ILocationRepository Location { get; private set; }
    }
}
