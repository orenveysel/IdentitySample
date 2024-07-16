using KitapYorum.Entites.Abstract;
using KitapYorum.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using KitapYorum.Entites.Concrete;
namespace KitapYorum.BL.Abstract
{
    public interface IYazarManager<TContext,T,TId> : IManager<TContext,T,TId>
        where TContext : DbContext, new()
        where T : Yazar
    {
        
    }
}
