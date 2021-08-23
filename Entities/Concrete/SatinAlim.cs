using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatinAlim:IEntity
    {
        public int SatinAlimId { get; set; }
        public int ToptanciId { get; set; }
        public DateTime Tarih { get; set; }
    }
}
