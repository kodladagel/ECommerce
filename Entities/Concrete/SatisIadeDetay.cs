using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatisIadeDetay:IEntity
    {
        public int SatisIadeDetayId { get; set; }
        public int SatisIadeId { get; set; }
        public int UrunId { get; set; }
        public decimal Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}
