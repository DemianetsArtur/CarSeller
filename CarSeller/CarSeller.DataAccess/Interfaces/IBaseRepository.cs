﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarSeller.DataAccess.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        Task<ICollection<TEntity>> GetAllAsync();
        Task<TEntity> GetById(int id);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
