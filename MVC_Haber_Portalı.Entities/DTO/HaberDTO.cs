using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Haber_Portalı.Entities.DTO
{
    public class HaberDTO
    {
        public string HaberBaslik { get; set; }

        public string HaberAltBaslik { get; set; }
        public string HaberResimYolu { get; set; }
        public string HaberBilgisi { get; set; }
    }
}
