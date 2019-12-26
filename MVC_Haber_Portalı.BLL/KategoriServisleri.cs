using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.DAL.Repository;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.BLL
{
   public class KategoriServisleri
    {
        private readonly KategoriRepository _kategoriRepository;

        public KategoriServisleri()
        {
            _kategoriRepository = new KategoriRepository();
        }

        public List<Kategori> GetCategories()
        {
            var kategorilerList = _kategoriRepository.GetAllCategories();

            return kategorilerList;
        }
    }
}
