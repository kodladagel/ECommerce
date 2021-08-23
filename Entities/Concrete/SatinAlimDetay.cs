using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatinAlimDetay:IEntity
    {
        public int SatinAlimDetayId { get; set; }
        public int SatinAlimId { get; set; }
        public int UrunId { get; set; }
        public decimal Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}
