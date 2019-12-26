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
    public class Haber : IEntity
    {
        public Haber()
        {
            Yorumlar = new HashSet<Yorum>();
        }

        [Key]
        public int HaberId { get; set; }

        [Required, MaxLength(50)]
        public string HaberAdi { get; set; }
        public string HaberAciklama { get; set; }
        
        public string Haberİcerik { get; set; }

        [MaxLength(500)]
        public string HaberBaslik { get; set; }
        public string HaberAltBaslik { get; set; }

        [MaxLength(500)]
        public string HaberResimYolu { get; set; }
     

        [Required, ForeignKey("Kategori")]
        public int KategoriId { get; set; }

        public Kategori Kategori { get; set; }

        [Required, ForeignKey("Yazar")]
        public int YazarId { get; set; }

        public Yazar Yazar { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public DateTime YayinlamaTarihi { get; set; }

        public bool aktifMi { get; set; }

        public virtual ICollection<Yorum> Yorumlar { get; set; }

    }
}
