using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace MVC_Haber_Portalı.BLL.IServices.IBaseServices
{
    public interface IService<TEntity, TKey>
        where TEntity : class, IEntity, new()
    {
        List<TEntity> Getir(Expression<Func<TEntity, bool>> exp = null);

        TEntity Getir(TKey id);

        string Guncelle(TEntity entity);

        string Ekle(TEntity entity);
    }
}
