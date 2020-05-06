using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Eleva.Data.Context;
using Eleva.Domain.Interfaces;
using Eleva.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Eleva.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new() 
    {
        protected readonly ElevaDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        protected Repository(ElevaDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<int> Create(TEntity entity)
        {
            _dbSet.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<int> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<int> Destroy(Guid id)
        {
            _dbSet.Remove(new TEntity { Id = id });
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
