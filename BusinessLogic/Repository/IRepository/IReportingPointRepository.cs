using AppModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository.IRepository
{
    public interface IReportingPointRepository : IRepository<ReportingPointModel>
    {
        Task<string> isLogged(DateTime actionDate, string actionBy, string actionDescription, string actionId);
    }
}
