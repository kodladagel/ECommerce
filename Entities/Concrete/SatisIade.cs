using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatisIade:IEntity
    {
        public int SatisIadeId { get; set; }
        public int MusteriId { get; set; }
        public DateTime Tarih { get; set; }
    }
}
