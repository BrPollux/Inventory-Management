using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Entity
{
    public class Depo
    {
        public int DepoId { get; set; }
        public int DepoKodu { get; set; }
        public string DepoAdi { get; set; }       
        public string DepoAdres { get; set; }       
        public string DepoAciklama { get; set; }
        public List<Product> Products { get; set; }
    }
}
