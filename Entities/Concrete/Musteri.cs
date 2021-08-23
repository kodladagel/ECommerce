using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Musteri:IEntity
    {
        public int MusteriId { get; set; }
        public string Firma { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }


    }
}
