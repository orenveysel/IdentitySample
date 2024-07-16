using KitapYorum.BL.Abstract;
using KitapYorum.Entites.Abstract;
using KitapYorum.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.BL.Concrete
{
    public class YazarManager<TContext, T, TId> :Manager<TContext,T,TId>, IYazarManager<TContext, T, TId>
        where TContext : DbContext, new()
        where T : Yazar
    {
        public YazarManager(TContext context):base(context)
        {
            
        }

        public override Task<int> AddAsync(T entity)
        {

            // 15 yasindan kucuk ise
            if ((DateTime.Now.Year - entity.DogumTarihi.Value.Year) < 15)
            {
                throw new Exception("Buyude gel ..");
            }
            return base.AddAsync(entity);
        }
    }
}
