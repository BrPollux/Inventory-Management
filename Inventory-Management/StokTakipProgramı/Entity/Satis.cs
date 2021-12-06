using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Entity
{
    public class Satis
    {
        public int SatisId { get; set; }
        public string SStokKodu { get; set; }
        public string SStokAdı { get; set; }
        public int SatisMiktarı { get; set; }
        public double SBirimFiyat { get; set; }
        public double SToplamFiyat { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
