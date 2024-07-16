using KitapYorum.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? MyUserId { get; set; }

        public MyUser? MyUser { get; set; }
    }
}
