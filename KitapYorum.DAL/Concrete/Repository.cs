using KitapYorum.DAL.Abstract;
using KitapYorum.Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.DAL.Concrete
{
    public class Repository<TContext, T, TId> : IRepository<TContext, T, TId>
        where TContext : DbContext, new()
        where T : BaseEntity
    {
        protected readonly TContext context;




        public  Repository(TContext context)
        {
            this.context = context;
        }
        public async virtual  Task<int> AddAsync(T entity)
        {
           await  context.Set<T>().AddAsync(entity);
           return await  context.SaveChangesAsync();
        }
        public virtual async Task<int> UpdateAsync(T entity)
        {
             context.Set<T>().Update(entity);
            return await context.SaveChangesAsync();
        }
        public virtual async Task<int> DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public virtual async  Task<T?> FindAsync(TId id)
        {
            var result = await context.Set<T>().FindAsync(id);
            return result;
        }
        public virtual async Task<T?> GetByAsync(Expression<Func<T, bool>>? filter)
        {
            if (filter == null)
            {
                return await context.Set<T>().FirstOrDefaultAsync();
            }
            else
            {
                return await context.Set<T>().Where(filter).FirstOrDefaultAsync();
            }
        }
        public virtual async Task<IEnumerable<T>?> GetAllAsync(Expression<Func<T, bool>>? filter)
        {
            if (filter == null)
            {
                return await context.Set<T>().ToListAsync();
            }
            else
            {
                return await context.Set<T>().Where(filter).ToListAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllIncludeAsync(Expression<Func<T, bool>>? filter, params Expression<Func<T, object>>[] include)
        {
           
            IQueryable<T> query = context.Set<T>();
            if (filter != null)
            {
                query.Where(filter);
            }
           
            return await include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToListAsync();

        }

      

        
    }
}
