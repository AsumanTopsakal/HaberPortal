using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.DAL.Mappings
{
    public class ContactPageMappings: EntityTypeConfiguration<ContactPage>
    {
        public ContactPageMappings()
        {
            ToTable("Contact", "blog");   
        }
    }
}
