using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Urun:IEntity
    {
        public int UrunId { get; set; }
        public int KategoriId { get; set; }
        public int MarkaId { get; set; }
        public int UyumMarkaId { get; set; }
        public int UyumModelId { get; set; }
        public string StokKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal ToptanFiyati { get; set; }
        public decimal PerakendeFiyati { get; set; }
        public decimal StokMiktari { get; set; }
    }
}
