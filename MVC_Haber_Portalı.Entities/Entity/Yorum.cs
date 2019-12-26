using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Haber_Portalı.Entities
{
    public class Yorum : IEntity
    {
        [Key]
        public int YorumId { get; set; }

        [Required, ForeignKey("Haber")]
        public int HaberId { get; set; }

        public Haber Haber { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        [MaxLength(50)]
        public string Soyad { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(500)]
        public string Message { get; set; }

        public DateTime YorumTarihi { get; set; }
    }
}
