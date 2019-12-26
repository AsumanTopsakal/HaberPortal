using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Haber_Portalı.BLL;
using MVC_Haber_Portalı.Entities;
using MVC_Haber_Portalı.UI.Models;

namespace MVC_Haber_Portalı.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HaberServisleri _haberServices;
        private readonly KategoriServisleri _kategoriServices;

        public HomeController()
        {
            _haberServices = new HaberServisleri();
            _kategoriServices = new KategoriServisleri();
        }




        public ActionResult Index()
        {
            List<Haber> newsList = new HaberServisleri().GetNews();

            List<Kategori> categoriesList = new KategoriServisleri().GetCategories();

            var model = new HomeIndexViewModel
            {
                Haberler = newsList,
                Kategoriler = categoriesList
            };

            return View(model);
        }

        public ActionResult About()
        {
            var aboutService = new AboutPageService();
            var about = aboutService.GetAbout();
            return  View(about);
        }

      
        public ActionResult Contact() => View();

    }
}