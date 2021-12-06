using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Models
{
    public class ProductViewModel
    {
        public Product product { get; set; }
        public StokKart stokKart { get; set; }
        public Depo depo { get; set; }
    }
}
