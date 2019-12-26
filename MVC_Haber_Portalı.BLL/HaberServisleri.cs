using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Haber_Portalı.DAL.Repository;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.BLL
{
    public class HaberServisleri
    {
        private readonly HaberRepository _haberRepository;

        public HaberServisleri()
        {
            _haberRepository = new HaberRepository();
        }

        public List<Haber> GetNews() //burada news yollayınca databaseden değişen şey presentationda değişmemeli. Bu güvelik açığı oluştururur. Buraya database değişkeni değil dto news taşıyın. veritabanında dto ile eşleşmedği için gelmeyecek.
        {
            var haberlerList = _haberRepository.GetAllNews();

            return haberlerList;
        }
    }
}
