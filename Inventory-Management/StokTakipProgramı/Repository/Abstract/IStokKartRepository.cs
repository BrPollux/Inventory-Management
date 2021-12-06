using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Abstract
{
    public interface IStokKartRepository
    {
        StokKart GetById(int stokkartId);
        IQueryable<StokKart> GetAll();

        void AddStokKart(StokKart entity);
        void UpdateStokKart(StokKart entity);
        void DeleteStokKart(int stokkartId);
    }
}
