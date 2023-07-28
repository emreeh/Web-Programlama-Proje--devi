using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PakHos.Data.Abstract;
using PakHos.Entities;

namespace PakHos.Services.Abstract
{
    public interface IService<T> :IRepository<T> where T : class,IEntity,new()
    {
    }
}
