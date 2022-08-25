using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNLayerProject.API.Repository;

namespace UdemyNLayerProject.DATA.Repositorys
{
    public class Repository<T>: IRepository<T> where T : class
    {
        public readonly DbContext _Context;
        public readonly DbSet<T> _DbSet;

        public Repository(DbContext Context)
        {
            _Context = Context;
            _DbSet = Context.Set<T>();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _DbSet.ToListAsync();
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
        {
           return _DbSet.Where(predicate);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _DbSet.SingleOrDefaultAsync(predicate);
        }

        public async Task AddAsync(T entity)
        {
            await _DbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _DbSet.AddRangeAsync(entities);
        }

        public void Remove(T entity)
        {
            _DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _DbSet.RemoveRange(entities);
        }

        public T Update(T entity)
        {
            _Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}