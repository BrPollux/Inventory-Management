using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Concrete.EntityFramework
{
    public class EfTransferRepository : ITransferRepository
    {
        private StokContext context;

        public EfTransferRepository(StokContext _context)
        {
            context = _context;
        }
        public void AddTransfer(Transfer entity)
        {
            context.Transferler.Add(entity);
            context.SaveChanges();
        }

        public void DeleteTransfer(int transferId)
        {
            var transfer = context.Transferler.FirstOrDefault(p => p.TransferId == transferId);
            if (transfer != null)
            {
                context.Transferler.Remove(transfer);
                context.SaveChanges();
            }
        }

        public IQueryable<Transfer> GetAll()
        {
            return context.Transferler;
        }
    }
}
