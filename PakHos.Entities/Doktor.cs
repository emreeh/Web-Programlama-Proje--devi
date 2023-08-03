using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Entities
{
   public class Doktor: IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        public int PolikinikId { get; set; }
        public bool AktifMi { get; set; }
        public string? Notlar { get; set; }
       public virtual Poliklinik? Poliklinik { get; set; } //Doktor sınıfı ile Poliklinik sınıfı arasında bağlantı
    }
}
