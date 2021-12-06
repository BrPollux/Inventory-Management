using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Concrete.EntityFramework
{
    public class EfStokKartRepository : IStokKartRepository
    {
        private StokContext context;

        public EfStokKartRepository(StokContext _context)
        {
            context = _context;
        }
        public void AddStokKart(StokKart entity)
        {
            context.StokKartları.Add(entity);
            context.SaveChanges();
        }

        public void DeleteStokKart(int stokkartId)
        {
            var stokkart = context.StokKartları.FirstOrDefault(p => p.StokKartId == stokkartId);
            if (stokkart!=null)
            {
                context.StokKartları.Remove(stokkart);
                context.SaveChanges();
            }

        }

        public IQueryable<StokKart> GetAll()
        {
            return context.StokKartları;
        }

        public StokKart GetById(int stokkartId)
        {
            return context.StokKartları.FirstOrDefault(p => p.StokKartId == stokkartId);
        }

        public void UpdateStokKart(StokKart entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
