using CleanArchWithCQRS.Application.Contracts.Persistance.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Persistance.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private ProjectDbContext _projectDbContext;

        public BaseRepository(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _projectDbContext.AddAsync(entity);
            await _projectDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(TEntity entity)
        {
            _projectDbContext.Set<TEntity>().Remove(entity);
            await _projectDbContext.SaveChangesAsync();
        }

        public async Task<TEntity> Get(Guid id)
        {
            return await _projectDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<IReadOnlyList<TEntity>> GetAll()
        {
            return await _projectDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            _projectDbContext.Entry(entity).State = EntityState.Modified;
            await _projectDbContext.SaveChangesAsync();
        }
    }
}
