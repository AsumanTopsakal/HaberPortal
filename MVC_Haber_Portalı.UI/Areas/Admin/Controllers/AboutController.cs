using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Haber_Portalı.BLL;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.UI.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        private AboutPageService _aboutPageService;


        public AboutController()
        {
            _aboutPageService = new AboutPageService();
        }


        [HttpGet]
        public ActionResult Index()
        {
            var aboutModel = _aboutPageService.GetAbout();
            return View(aboutModel);
        }
        [HttpGet]
        public ActionResult Edit()
        {
            var aboutModel = _aboutPageService.GetAbout();
            return View(aboutModel);

        }
        [HttpPost]
        public ActionResult Edit(AboutPage aboutPage)
        {
            return View();
        }


    }
}