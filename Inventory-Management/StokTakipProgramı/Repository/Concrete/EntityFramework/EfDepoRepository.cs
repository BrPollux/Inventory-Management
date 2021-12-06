using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Concrete.EntityFramework
{
    public class EfDepoRepository : IDepoRepository
    {
        private StokContext context;

        public EfDepoRepository(StokContext _context)
        {
            context = _context;
        }
        public void AddDepo(Depo entity)
        {
            context.Depolar.Add(entity);
            context.SaveChanges();
        }

        public void DeleteDepo(int depoId)
        {
            var depo = context.Depolar.FirstOrDefault(p => p.DepoId == depoId);
            if (depo != null)
            {
                context.Depolar.Remove(depo);
                context.SaveChanges();
            }
        }

        public IQueryable<Depo> GetAll()
        {
            return context.Depolar;
        }

        public Depo GetById(int depoId)
        {
            return context.Depolar.FirstOrDefault(p => p.DepoId == depoId);
        }

        public void UpdateDepo(Depo entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
