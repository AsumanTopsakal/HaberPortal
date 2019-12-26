using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Haber_Portalı.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}