using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Entity
{
    public class StokKart
    {
        public int StokKartId { get; set; }
        public int StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string StokBirim { get; set; }
        public string StokAciklama { get; set; }
        public double StokAlis { get; set; }
        public double StokSatis { get; set; }

        public List<Product> Products { get; set; }

    }
}
