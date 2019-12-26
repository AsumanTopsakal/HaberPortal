﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.IBaseRepository
{
    public interface IDeleteById<TKey>
    {
        int Delete(TKey id);
    }
}
