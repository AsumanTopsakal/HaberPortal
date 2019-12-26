using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.DAL.Mappings;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.DAL
{
    public class MVC_Haber_Portalı_Context :DbContext
    {
        public MVC_Haber_Portalı_Context() 
        {
            Configuration.LazyLoadingEnabled = false;
            Database.Connection.ConnectionString = @"Server = ASUMAN\SQLEXPRESS04; Database = MVC_HaberPortali; Trusted_Connection=True; MultipleActiveResultSets = True;";

            var value = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
     

        public DbSet<Galeri> Galeriler { get; set; }

        public DbSet<Haber> Haberler { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<AboutPage> AboutPage { get; set; }
        public DbSet<ContactPage> ContactPage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new KategoriMappings());
            modelBuilder.Configurations.Add(new ContactPageMappings());
        }

    }
}
