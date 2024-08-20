using FinApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infrastructure.InfrastructureBases
{
    public class GenericRepositoryAsync<T> : IGenericRepoAsync<T> where T : class
    {
        private readonly AppDbContext appDbContext;

        public GenericRepositoryAsync(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public virtual async Task<List<T>> GetAllAsync()
        {
            return await appDbContext.Set<T>().ToListAsync();
        }
        public virtual async Task<T> GetByIdAsync(int id)
        {

            return await appDbContext.Set<T>().FindAsync(id);
        }


        public IQueryable<T> GetTableNoTracking()
        {
            return appDbContext.Set<T>().AsNoTracking().AsQueryable();
        }


        public virtual async Task AddRangeAsync(ICollection<T> entities)
        {
            await appDbContext.Set<T>().AddRangeAsync(entities);
            await appDbContext.SaveChangesAsync();

        }
        public virtual async Task<T> AddAsync(T entity)
        {
            await appDbContext.Set<T>().AddAsync(entity);
            await appDbContext.SaveChangesAsync();

            return entity;
        }

        public virtual async Task UpdateAsync(T entity)
        {
            appDbContext.Set<T>().Update(entity);
            await appDbContext.SaveChangesAsync();

        }

        public virtual async Task DeleteAsync(T entity)
        {
            appDbContext.Set<T>().Remove(entity);
            await appDbContext.SaveChangesAsync();
        }
        public virtual async Task DeleteRangeAsync(ICollection<T> entities)
        {
            foreach (var entity in entities)
            {
                appDbContext.Entry(entity).State = EntityState.Deleted;
            }
            await appDbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await appDbContext.SaveChangesAsync();
        }



        public IDbContextTransaction BeginTransaction()
        {
            return appDbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            appDbContext.Database.CommitTransaction();

        }

        public void RollBack()
        {
            appDbContext.Database.RollbackTransaction();
        }

        public IQueryable<T> GetTableAsTracking()
        {
            return appDbContext.Set<T>().AsQueryable();

        }

        public virtual async Task UpdateRangeAsync(ICollection<T> entities)
        {
            appDbContext.Set<T>().UpdateRange(entities);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await appDbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await appDbContext.Database.CommitTransactionAsync();
        }

        public async Task RollBackAsync()
        {
            await appDbContext.Database.RollbackTransactionAsync();
        }      
    }
}
