using Microsoft.EntityFrameworkCore;
using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Repository.Concrete.EntityFramework
{
    public class StokContext:DbContext
    {
        public StokContext(DbContextOptions<StokContext> options)
            :base(options)
        {

        }
       
        public DbSet<Alis> Alislar { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StokKart> StokKartları { get; set; }
        public DbSet<Transfer> Transferler { get; set; }
    }
}
