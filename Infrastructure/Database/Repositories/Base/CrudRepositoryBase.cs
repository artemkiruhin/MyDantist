
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories.Base
{
    public class CrudRepositoryBase<T> : ICrudRepository<T> where T : class
    {
        protected readonly DantistClinicDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public CrudRepositoryBase(DantistClinicDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<bool> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return await SaveChangesAsync();
        }

        public virtual async Task<bool> Delete(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null) return false;

            _dbSet.Remove(entity);
            return await SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T?> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return await SaveChangesAsync();
        }

        protected async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
