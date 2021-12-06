using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Entity
{
    public class Transfer
    {
        public int TransferId { get; set; }
        public string TStokKodu { get; set; }
        public string TStokAdı { get; set; }
        public int TransferMiktarı { get; set; }
        public string EskiDepo { get; set; }
        public string YeniDepo { get; set; }       
        public DateTime TransferTarihi { get; set; }
    }
}
