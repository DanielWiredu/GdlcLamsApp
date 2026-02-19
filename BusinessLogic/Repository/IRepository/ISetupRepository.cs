using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository.IRepository
{
    public interface ISetupRepository 
    {
        Task<int> AddGang(TblGang model);
        Task<IEnumerable<TblGang>> GetAllGangs();
        Task<int> RemoveGang(int Id);
        Task<int> UpdateGang(TblGang model);
        Task<int> AddVessel(TblVessel model);
        Task<IEnumerable<TblVessel>> GetAllVessels();
        Task<int> RemoveVessel(int Id);
        Task<int> UpdateVessel(TblVessel model);
        Task<int> AddCargo(TblCargo model);
        Task<IEnumerable<TblCargo>> GetAllCargo();
        Task<int> RemoveCargo(int Id);
        Task<int> UpdateCargo(TblCargo model);
        Task<int> AddNationality(TblNationality model);
        Task<IEnumerable<TblNationality>> GetAllNationality();
        Task<int> RemoveNationality(int Id);
        Task<int> UpdateNationality(TblNationality model);
    }
}
