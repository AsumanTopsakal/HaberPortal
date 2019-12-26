using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.DAL.Mappings
{
    public class KategoriMappings : EntityTypeConfiguration<Kategori>
    {
        public KategoriMappings()
        {
            ToTable("Kategoriler");
        }
    }
}
