using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Abstract
{
    public interface ISatisRepository
    {
        void AddSatis(Satis entity);
        void DeleteSatis(int satisId);
        IQueryable<Satis> GetAll();
    }
}
