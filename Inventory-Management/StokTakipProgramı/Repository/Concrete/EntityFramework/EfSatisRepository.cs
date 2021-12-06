using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Concrete.EntityFramework
{
    public class EfSatisRepository : ISatisRepository
    {
        private StokContext context;

        public EfSatisRepository(StokContext _context)
        {
            context = _context;
        }
        public void AddSatis(Satis entity)
        {
            context.Satislar.Add(entity);
            context.SaveChanges();
        }

        public void DeleteSatis(int satisId)
        {
            var satis = context.Satislar.FirstOrDefault(p => p.SatisId == satisId);
            if (satis != null)
            {
                context.Satislar.Remove(satis);
                context.SaveChanges();
            }
        }

        public IQueryable<Satis> GetAll()
        {
            return context.Satislar;
        }
    }
}
