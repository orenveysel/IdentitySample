using KitapYorum.DAL.Abstract;
using KitapYorum.Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.BL.Abstract
{
    public interface IManager<TContext,T,TId> : IRepository<TContext,T,TId>
        where TContext : DbContext, new()
        where T : BaseEntity
    {
    }
}
