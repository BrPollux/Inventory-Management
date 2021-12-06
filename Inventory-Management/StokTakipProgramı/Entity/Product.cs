using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductAdet { get; set; }

        public int StokKartId { get; set; }
        public StokKart StokKart { get; set; }

        public int? DepoId { get; set; }
        public Depo Depo { get; set; }
    }
}
