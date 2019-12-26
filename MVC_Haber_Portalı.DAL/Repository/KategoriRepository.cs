using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.BaseClasses.EntityFramework;
using MVC_Haber_Portalı.DAL.IRepository;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.DAL.Repository
{
    public class KategoriRepository 
    {
        public List<Kategori> GetAllCategories()
        {
            List<Kategori> kategoriler;
            using (MVC_Haber_Portalı_Context database = new MVC_Haber_Portalı_Context())
            {
                kategoriler = database.Kategoriler.ToList();
            }

            return kategoriler;
        }
    }
}
