using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.UI.Models
{
    public class HomeIndexViewModel
    {
        public List<Haber> Haberler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}