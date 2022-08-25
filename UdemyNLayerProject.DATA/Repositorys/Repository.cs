using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNLayerProject.API.Repository;
using UdemyNlayerProject.CORE.Repository;

namespace UdemyNLayerProject.DATA.Repositorys
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity : class
    {
        public readonly DbContext _Context;
        public readonly DbSet<TEntity> _DbSet;

        public Repository(AppDbContext Context)
        {
            _Context = Context;
            _DbSet = Context.Set<TEntity>();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _DbSet.Where(predicate).ToListAsync();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _DbSet.SingleOrDefaultAsync(predicate);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _DbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _DbSet.AddRangeAsync(entities);
        }

        public void Remove(TEntity entity)
        {
            _DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _DbSet.RemoveRange(entities);
        }

        public TEntity Update(TEntity entity)
        {
            _Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}