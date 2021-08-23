using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatinAlimIadeDetay:IEntity
    {
        public int SatinAlimIadeDetayId { get; set; }
        public int SatinAlimIadeId { get; set; }
        public int UrunId { get; set; }
        public decimal Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}
