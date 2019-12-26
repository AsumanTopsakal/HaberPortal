using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.IBaseRepository
{
    // TEntity bir class olmalı ve IEntity interface'inden implement almalıdır ve instance alınabilir bir
    // class olmalıdır. Abstract class gelemez.
    public interface IGetById<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        TEntity GetById(TKey id);

        //TEntity yerine mesela Kategori entity tipini verdik. TKey yerine de int tipini verdiğimizde
        //Kategori GetById(int id)


    }
}
