using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.IBaseRepository;
using Core.Entities;
using MVC_Haber_Portalı.BLL.IServices.IBaseServices;

namespace MVC_Haber_Portalı.BLL.Services
{
    public class ServiceBase<TEntity, TKey> : IService<TEntity, TKey>
        where TEntity : class, IEntity, new()
    {
        IRepository<TEntity, TKey> _repository;

        public ServiceBase(IRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public string Ekle(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
                return "Kayıt işlemi başarı ile tamamlanmıştır.";
            }
            catch (Exception ex)
            {
                return "Bir hata nedeniyle kayıt işlemi yapılamamıştır.";
            }
        }

        public string Sil(TEntity entity)
        {
            try
            {
                _repository.Delete(entity);
                return "Silme işlemi başarı ile tamamlanmıştır.";
            }
            catch (Exception)
            {
                return "Bir hata nedeniyle silme işlemi yapılamamıştır.";
            }
        }

        public List<TEntity> Getir(Expression<Func<TEntity, bool>> exp = null)
        {
            return _repository.Get(exp);
        }

        public TEntity Getir(TKey id)
        {
            return _repository.GetById(id);
        }

        public string Guncelle(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
                return "Guncelleme başarıyla tamamlandı";
            }
            catch (Exception e)
            {
                return "Bir hata nedeniyle güncelleme yapılamamıştır. Hata:" + e.Message;
            }
        }
    }
}
