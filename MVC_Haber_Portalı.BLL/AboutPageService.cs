using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.DAL;
using MVC_Haber_Portalı.DAL.Repository;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.BLL
{
    public class AboutPageService
    {
        //    private MVC_Haber_Portalı_Context database;
        //    public AboutPageService()
        //    {
        //        database = new MVC_Haber_Portalı_Context();

        //    }
        //    public AboutPage GetAboutPage()
        //    {
        //        var aboutPage = database.AboutPage;
        //        return aboutPage;

        //    }

        private AboutRepository _aboutRepository;
        public AboutPageService()
        {
            _aboutRepository = new AboutRepository();
        }
        public AboutPage GetAbout()
        {
            var model = _aboutRepository.GetAboutPage();
            return model;
        }
}


   
}
