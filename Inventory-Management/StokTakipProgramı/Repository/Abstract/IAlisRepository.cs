using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Abstract
{
    public interface IAlisRepository
    {
        void AddAlis(Alis entity);
        void DeleteAlis(int alisId);
        IQueryable<Alis> GetAll();
    }
}
