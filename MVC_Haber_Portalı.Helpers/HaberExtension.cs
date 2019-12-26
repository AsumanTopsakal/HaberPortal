using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.Entities;
using MVC_Haber_Portalı.Entities.DTO;

namespace MVC_Haber_Portalı.Helpers
{
    public static class HaberExtension
    {
        public static HaberDTO GetNewsDto(Haber haber)
        {
            HaberDTO DTONews = new HaberDTO
            {
                HaberAltBaslik = haber.HaberAltBaslik,
                HaberBaslik = haber.HaberBaslik,
                HaberResimYolu = haber.HaberResimYolu,
                HaberBilgisi = haber.Haberİcerik.Substring(0, 20)



            };
            return DTONews;
        }

        public static List<HaberDTO> GetNewsDTO(List<Haber> haberler)
        {
            List<HaberDTO> haberlerList = new List<HaberDTO>();
            haberlerList = haberler.Select(i => new HaberDTO
            {
                HaberAltBaslik = i.HaberAltBaslik,
                HaberBaslik = i.HaberBaslik,
                HaberResimYolu = i.HaberResimYolu,
                HaberBilgisi = i.Haberİcerik.Substring(0, 20)

            }).ToList();
            return haberlerList;
        }
    }
}
