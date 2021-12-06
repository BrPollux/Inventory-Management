using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Concrete.EntityFramework
{
    public class EfAlisRepository : IAlisRepository
    {
        private StokContext context;

        public EfAlisRepository(StokContext _context)
        {
            context = _context;
        }
        public void AddAlis(Alis entity)
        {
            context.Alislar.Add(entity);
            context.SaveChanges();
        }

        public void DeleteAlis(int alisId)
        {
            var alis = context.Alislar.FirstOrDefault(p => p.AlisId == alisId);
            if (alis != null)
            {
                context.Alislar.Remove(alis);
                context.SaveChanges();
            }
        }

        public IQueryable<Alis> GetAll()
        {
            return context.Alislar;
        }
    }
}
