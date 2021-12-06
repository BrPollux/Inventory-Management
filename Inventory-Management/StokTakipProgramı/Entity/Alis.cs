using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Entity
{
    public class Alis
    {
        public int AlisId { get; set; }
        public string AStokKodu { get; set; }
        public string AStokAdı { get; set; }
        public int AlisMiktarı { get; set; }
        public double ABirimFiyat { get; set; }
        public double AToplamFiyat { get; set; }
        public DateTime AlisTarihi { get; set; }
    }
}
