using StokTakipProgramı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Models
{
    public class PCreateViewModel
    {
        public StokKart stokKart { get; set; }
        public Product product { get; set; }
    }
}
