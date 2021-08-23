using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatisDetay:IEntity
    {
        public int SatisDetayId { get; set; }
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public decimal Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}
