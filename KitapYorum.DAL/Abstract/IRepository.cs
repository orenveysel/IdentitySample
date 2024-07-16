using KitapYorum.Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.DAL.Abstract
{
    public interface IRepository<TContext,T,TId> 
        where T : BaseEntity  // DbContext icerisindeki entity'i temsil eder
        where TContext : DbContext, new() // Dbcontext Nesnesi
    {
        public   Task<int> AddAsync(T entity);
        public Task<int> UpdateAsync(T entity);
        public Task<int> DeleteAsync(T entity);

        
        public Task<T?> GetByAsync(Expression<Func<T,bool>>? filter);
        public Task<T?> FindAsync(TId id);

        public Task<IEnumerable<T>?> GetAllAsync(Expression<Func<T, bool>>? filter);

        public Task<IEnumerable<T>> GetAllIncludeAsync(
            Expression<Func<T, bool>>? filter, // Burasi sorgu icin gerekli predicate
            params Expression<Func<T, object>>[] include); // join atilacak entity'lerin listesi);
    }
}
