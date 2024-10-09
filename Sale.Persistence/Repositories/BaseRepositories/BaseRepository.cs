using Microsoft.EntityFrameworkCore;
using Sale.Application.Interfaces;
using Sale.Persistence.DbContextes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Persistence.Repositories.BaseRepositories
{
    internal class BaseGenericRepository<TEntity> : IBaseGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDynamicDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseGenericRepository(ApplicationDynamicDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }

        public async Task<TEntity> GetByIdAsync(object id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                await _dbSet.AddAsync(entity, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                return entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding entity: {ex.Message}");
                return null;
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync(cancellationToken);
                return entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating entity: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> DeleteAsync(object id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await GetByIdAsync(id, cancellationToken);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    await _context.SaveChangesAsync(cancellationToken);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting entity: {ex.Message}");
                return false;
            }
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.Where(predicate).ToListAsync(cancellationToken);
        }
        public async Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return await _dbSet.CountAsync(cancellationToken); // شمارش تمامی موجودیت‌ها
        }
        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.CountAsync(predicate, cancellationToken); // شمارش با شرط
        }
        public IQueryable<TEntity> Query()
        {
            return _dbSet.AsQueryable();
        }
        public async Task<IEnumerable<TEntity>> BulkInsertAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            try
            {
                await _dbSet.AddRangeAsync(entities, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                return entities; // مجموعه موجودیت‌های افزوده‌شده
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error bulk inserting entities: {ex.Message}");
                return null; // در صورت بروز خطا، null برگردانده می‌شود
            }
        }
        public async Task<IEnumerable<TEntity>> BulkUpdateAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            try
            {
                _dbSet.UpdateRange(entities);
                await _context.SaveChangesAsync(cancellationToken);
                return entities;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error bulk updating entities: {ex.Message}");
                return default;
            }
        }
        public async Task<int> BulkDeleteAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            try
            {
                _dbSet.RemoveRange(entities);
               var result =  await _context.SaveChangesAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error bulk deleting entities: {ex.Message}");
                return default;
            }
        }
    }
}
