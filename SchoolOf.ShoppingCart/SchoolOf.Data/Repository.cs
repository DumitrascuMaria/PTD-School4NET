using Microsoft.EntityFrameworkCore;
using SchoolOf.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntityModel
    {
        private readonly DbSet<T> dbSet;
        public Repository(DatabaseContext context)
        {
            this.dbSet = context.Set<T>();
        }
        public T Add(T entity)
        {
            entity.CreatedAt = DateTimeOffset.Now;
            return this.dbSet.Add(entity).Entity;
        }

        public async Task<bool> DeleteByIdAsync(long id)
        {
            var entityToBeDeleted = await this.GetById(id);
            entityToBeDeleted.IsDeleted = true;
            return this.dbSet.Update(entityToBeDeleted) is not null;

      
        }

        public IEnumerable<T> Find(Func<T, bool> searchCriteria)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(long id)
        {
            return await this.dbSet.FindAsync(id);
        }

        public T Update(T entity)
        {
            entity.ModifiedAt = DateTimeOffset.UtcNow;
            return this.dbSet.Update(entity).Entity;
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
