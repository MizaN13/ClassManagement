﻿using ClassManagement.Library.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassManagement.Library.Data
{
    public interface IRepository<T>
        : IRepository<T, Guid>
        where T : EntityBase<Guid>
    {
    }
    public interface IRepository<T, TKey>
        where T : EntityBase<TKey>
    {
        void Add(T entity);
        void Delete(TKey entityId);
        void Delete(T entity);
        void Edit(T entity);
        IQueryable<T> Get();
        T Get(TKey entityId);
        T Get(T entity);

    }
}
