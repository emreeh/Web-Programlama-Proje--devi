using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Entities
{
    public class Randevu:IEntity
    {
        public int Id { get; set; }
        public int DoktorId { get; set; }
        public int HastaId { get; set; }
        //public decimal SatisFiyati { get; set; }
        public DateTime SatisTarihi { get; set; }
        public virtual Doktor doktor { get; set; }
        public virtual Hasta Hasta { get; set; }
    }
}
