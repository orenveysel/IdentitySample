using KitapYorum.BL.Abstract;
using KitapYorum.DAL.Concrete;
using KitapYorum.Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.BL.Concrete
{
    public class Manager<TContext,T,TId> :Repository<TContext,T,TId>,IManager<TContext,T,TId>
        where TContext : DbContext, new()
        where T : BaseEntity
    {
        public Manager(TContext context):base(context)
        {
            
        }
    }
}
