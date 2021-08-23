using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class LmcContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseMySQL("server=localhost;database=testdatabase;user=root;password=toor");
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Toptanci> Toptancilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<UyumMarka> UyumMarkalar { get; set; }
        public DbSet<UyumModel> UyumModeller { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<AlinanOdeme> AlinanOdemeler { get; set; }
        public DbSet<YapilanOdeme> YapilanOdemeler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatinAlim> SatinAlimlar { get; set; }
        public DbSet<SatinAlimDetay> SatinAlimDetaylar { get; set; }
        public DbSet<SatisDetay> SatisDetaylar { get; set; }
        public DbSet<SatisIade> SatisIadeler { get; set; }
        public DbSet<SatinAlimIade> SatinAlimIadeler { get; set; }
        public DbSet<SatinAlimIadeDetay> SatinAlimIadeDetaylar { get; set; }
        public DbSet<SatisIadeDetay> SatisIadeDetaylar { get; set; }
    }
}
