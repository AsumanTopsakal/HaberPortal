using Core.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Haber_Portalı.Entities
{
    public class Admin : IEntity
    {
        public int AdminId { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        [Required, MaxLength(50)]
        public string Soyad { get; set; }

        [Required, MaxLength(50)]
        public string Eposta { get; set; }

        [Required, MaxLength(15)]
        public string Sifre { get; set; }

        public Rol Rol { get; set; }
    }
}
