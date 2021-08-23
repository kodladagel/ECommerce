using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Satis:IEntity
    {
        public int SatisId { get; set; }
        public int MusteriiId { get; set; }
        public DateTime Tarih { get; set; }
    }
}
