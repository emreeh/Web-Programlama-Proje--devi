using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Entities
{
    public interface IEntity //internalı public yap
    {
        public int Id { get; set; } //tüm classlar için ıd zorunlu olacak
    }
}
