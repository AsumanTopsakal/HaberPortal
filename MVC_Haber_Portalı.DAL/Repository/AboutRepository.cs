using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.DAL.Repository
{
    public class AboutRepository
    {
        private MVC_Haber_Portalı_Context database;
        public AboutRepository()
        {
            database = new MVC_Haber_Portalı_Context();

        }
        public AboutPage GetAboutPage()
        {
            var aboutPage = database.AboutPage.FirstOrDefault();
            return aboutPage;

        }
    }
}
