﻿using System.Linq.Expressions;

namespace JWTAppBackOffice.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
