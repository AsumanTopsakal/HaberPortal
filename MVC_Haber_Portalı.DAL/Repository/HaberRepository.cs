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
    public class HaberRepository 
    {
        public List<Haber> GetAllNews()
        {
            List<Haber> haberler;
            using (MVC_Haber_Portalı_Context databaseContext = new MVC_Haber_Portalı_Context())
            {
                haberler = databaseContext.Haberler.ToList();
            }

            return haberler;
        }
    }
}
