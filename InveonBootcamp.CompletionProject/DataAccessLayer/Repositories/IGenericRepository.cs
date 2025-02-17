﻿using InveonBootcamp.CompletionProject.Core.Models;
using System.Linq.Expressions;

namespace InveonBootcamp.CompletionProject.DataAccessLayer.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id); // User guid olunca hata veriyor
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        IQueryable<T> GetAll(); // Bu metodu ekliyoruz.
        Task AddRangeAsync(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<User> GetByEmailAsync(string email); // User guid olunca hata veriyor
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);


    }
}
