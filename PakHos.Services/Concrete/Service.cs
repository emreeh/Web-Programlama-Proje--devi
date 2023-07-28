using PakHos.Data;
using PakHos.Data.Abstract;
using PakHos.Data.Concrete;
using PakHos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Services.Concrete
{
    public class Service<T> : Repository<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
