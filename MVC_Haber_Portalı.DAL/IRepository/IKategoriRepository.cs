using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.IBaseRepository;
using MVC_Haber_Portalı.Entities;

namespace MVC_Haber_Portalı.DAL.IRepository
{
    public interface IKategoriRepository : IRepository<Kategori, int>
    {
    }
}
