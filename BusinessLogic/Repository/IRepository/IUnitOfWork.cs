using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ILocationRepository Locations { get; }
        IReportingPointRepository ReportingPoints { get; }
        IWorkerRepository Workers { get; }
    }
}
