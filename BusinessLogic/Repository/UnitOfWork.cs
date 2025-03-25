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
        private readonly IMapper _mapper;
        public UnitOfWork(ISqlDataAccess db, IMapper mapper) 
        {
            _db = db;
            _mapper = mapper;
            Locations = new LocationRepository(_db);
            ReportingPoints = new ReportingPointRepository(_db, _mapper);
            Workers = new WorkerRepository(_db);
        }
        public ILocationRepository Locations { get; private set; }
        public IReportingPointRepository ReportingPoints { get; private set; }
        public IWorkerRepository Workers { get; private set; }
    }
}
