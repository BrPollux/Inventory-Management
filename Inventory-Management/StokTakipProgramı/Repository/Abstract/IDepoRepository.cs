using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Abstract
{
    public interface IDepoRepository
    {
        Depo GetById(int depoId);
        IQueryable<Depo> GetAll();

        void AddDepo(Depo entity);
        void UpdateDepo(Depo entity);
        void DeleteDepo(int depoId);

    }
}
