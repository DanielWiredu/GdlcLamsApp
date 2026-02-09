using AutoMapper;
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
            Locations = new LocationRepository(_db);
            ReportingPoints = new ReportingPointRepository(_db);
            Workers = new WorkerRepository(_db);
        }
        public ILocationRepository Locations { get; private set; }
        public IReportingPointRepository ReportingPoints { get; private set; }
        public IWorkerRepository Workers { get; private set; }
    }
}
