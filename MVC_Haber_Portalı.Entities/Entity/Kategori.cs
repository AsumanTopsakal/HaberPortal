using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Haber_Portalı.Entities
{
    public class Kategori : IEntity
    {
        public Kategori()
        {
            Haberler = new HashSet<Haber>();
        }

        public int KategoriId { get; set; }

       
        public string KategoriAdi { get; set; }

        
        public string KategoriAciklama { get; set; }

        public virtual IEnumerable<Haber> Haberler { get; set; }
    }
}
