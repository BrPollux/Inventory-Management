using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Abstract
{
    public interface ITransferRepository
    {
        void AddTransfer (Transfer entity);
        void DeleteTransfer(int transferId);
        IQueryable<Transfer> GetAll();
    }
}
